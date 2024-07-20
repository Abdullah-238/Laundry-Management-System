using LMS_BussinessLogic;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washing_App.Order;
using static Washing_App.clsGlobal;

namespace Washing_App
{
    public partial class NewOrders : Form
    {
       

        clsLaundry Laundry;

        clsOrders Order;

        int _OrderID = -1; 

        decimal _Total = 0;

        public NewOrders()
        {
            InitializeComponent();
        }

        void _RefreashPriceTable ()
        {
            dgvPriceDetiles.DataSource = clsGlobal.dtPriceDetiles;

            if (dgvPriceDetiles.RowCount > 0)
            {
                dgvPriceDetiles.Columns[0].HeaderText = "ID";
                dgvPriceDetiles.Columns[0].Width = 40;

                dgvPriceDetiles.Columns[1].HeaderText = "Name";
                dgvPriceDetiles.Columns[1].Width = 175;

                dgvPriceDetiles.Columns[2].HeaderText = "Price";
                dgvPriceDetiles.Columns[2].Width = 50;

                dgvPriceDetiles.Columns[3].HeaderText = "Qty";
                dgvPriceDetiles.Columns[3].Width = 40;

                dgvPriceDetiles.Columns[4].HeaderText = "Amount";
                dgvPriceDetiles.Columns[4].Width = 70;

                _Total = Convert.ToDecimal(clsGlobal.dtPriceDetiles.Compute("SUM(Amount)", string.Empty));

            }
            else
            _Total = 0;

            lbTotal.Text = _Total.ToString();

        }

        void _CreateTable()
        {
            if (clsGlobal.dtPriceDetiles.Columns.Count <= 0)
            {
                clsGlobal.dtPriceDetiles.Columns.Add("ID", typeof(int));
                clsGlobal.dtPriceDetiles.Columns.Add("Name", typeof(string));
                clsGlobal.dtPriceDetiles.Columns.Add("Price", typeof(decimal));
                clsGlobal.dtPriceDetiles.Columns.Add("Qty", typeof(int));
                clsGlobal.dtPriceDetiles.Columns.Add("Amount", typeof(decimal));
            }
          

            FillLayoutWithItems();
        }

        void _ResetFormInfo()
        {
            _Total = 0; 
            btCheckOut.Enabled = true;
            btPrint.Enabled = false;
            txFirstName.Focus();

            txPhone.Text = Convert.ToString(0);
            txCustomerPaid.Text = Convert.ToString(0);

            clsGlobal.dtPriceDetiles.Rows.Clear();
            txFirstName.Clear();
            txLastName.Clear();
            txNote.Clear();
            txSearch.Clear();
            lbTotal.Text = _Total.ToString();

        }

        void FillLayoutWithItems()
        {
            DataTable _dtItems = clsItem.GetAllItems();

            int ItemID;

            foreach (DataRow dr in _dtItems.Rows)
            {
                ItemID = (int)dr["ItemID"];

                ucOrder ucOrder = new ucOrder();

                ucOrder.FillProudectINfo(ItemID);

                ucOrder.OnSelect += ucOrder_OnSelect;

                flpItems.Controls.Add(ucOrder);
            }
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            _CreateTable();
            _ResetFormInfo();
        }
       
        private void ucOrder_OnSelect(object sender, EventArgs e)
        {

            ucOrder Order = (ucOrder)sender;

            foreach (DataRow dr in clsGlobal.dtPriceDetiles.Rows)
            {
                if ((int)dr["ID"] == Order.ID)
                {
                    dr["Qty"] = (int)dr["Qty"] + 1;
                    dr["Amount"] = (decimal)dr["Price"] * (int)dr["Qty"];

                    _RefreashPriceTable();
                    return;
                }
            }

            clsGlobal.dtPriceDetiles.Rows.Add(Order.ID, Order.name, Order.Price, 1, Order.Price);

            _RefreashPriceTable();

        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(ucOrder Order in flpItems.Controls)
            {
                Order.Visible = Order.name.ToLower().Contains(txSearch.Text.ToLower());
            }
        }

        private void btRemoveAll_Click(object sender, EventArgs e)
        {
            clsGlobal.dtPriceDetiles.Rows.Clear();
            _Total = 0;
            lbTotal.Text = _Total.ToString();
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please fill all required faildes", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsGlobal.dtPriceDetiles.Rows.Count <= 0)
            {
                MessageBox.Show("Please select items to continue", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            clsCustomers Customer = new clsCustomers();

            Customer.FirstName = txFirstName.Text.Trim();
            Customer.LastName = txLastName.Text.Trim();
            Customer.Phone = txPhone.Text.Trim();

            if (!Customer.Save())
            {

                MessageBox.Show("Customer Order Saved Falid", "Error");
                return;
            }

            Order = new clsOrders();

            Order.CustomerID = Customer.CustomerID;
            Order.OrderDate = DateTime.Now;
            Order.Note = txNote.Text.Trim();
            Order.UserID = clsGlobal.CurrentUser.UserID;
            Order.LuandryID = clsGlobal.CurrentLaundry.LaundryID; 
            Order.OrderStatus = clsOrders.enStatus.eNew;
            Order.OrderPrice = _Total;
            Order.CustomerPaid = Convert.ToDecimal(txCustomerPaid.Text.Trim());
            if (rbFast.Checked) Order.WashingTime = clsOrders.enWashingTime.eFast; 
            else Order.WashingTime = clsOrders.enWashingTime.eNormal;


            if (Order.Save())
                _OrderID = Order.OrderID;
            else
            {
                MessageBox.Show("Order Saved Falid", "Error"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
          

            foreach(DataRow dr in clsGlobal.dtPriceDetiles.Rows)
            {
                clsOrderItems OrderItems = new clsOrderItems();

                OrderItems.OrderID = _OrderID;
                OrderItems.ItemID = (int)dr["ID"];
                OrderItems.NumberOfItems = (int)dr["Qty"];

               
                if (!OrderItems.Save())
                {
                    MessageBox.Show("Items Saved Falid", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Order Saved Succefully","Done", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            btPrint.Enabled = true;
            btCheckOut.Enabled = false;

            completeOrder.Create(Order);

            Order = clsOrders.Find(_OrderID);
            Laundry =  clsGlobal.CurrentLaundry; 
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (_OrderID == -1)
                return;

            printPreviewDialog1.ShowDialog();
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }

        private void txOnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txCustomerPaid_Validating(object sender, CancelEventArgs e)
        {
            TextBox Temp = ((TextBox)sender);
            if (_Total < decimal.Parse(Temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "please enter amount less than total!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }
        }
     
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.dtPriceDetiles.Rows.Count != 0)
            {
                int RowID = (int)dgvPriceDetiles.CurrentRow.Index;

                clsGlobal.dtPriceDetiles.Rows.RemoveAt(RowID);

                _RefreashPriceTable();
            }
          
        }

        private void dgvPriceDetiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && (clsGlobal.dtPriceDetiles.Rows.Count != 0))
            {
                int RowID = (int)dgvPriceDetiles.CurrentRow.Index;

                clsGlobal.dtPriceDetiles.Rows.RemoveAt(RowID);

                _RefreashPriceTable();

            }
        }

        private void btRemoveLastOne_Click(object sender, EventArgs e)
        {

            if (clsGlobal.dtPriceDetiles.Rows.Count != 0)
            {
                int RowID = (int)dgvPriceDetiles.Rows.Count - 1;

                clsGlobal.dtPriceDetiles.Rows.RemoveAt(RowID);

                _RefreashPriceTable();

            }
           

            
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rect = new Rectangle(0, 350, 1000, 50);

            SolidBrush blueBrush = new SolidBrush(Color.DarkCyan);

            e.Graphics.DrawString("\tInvoice"  , new Font("Poppins", 20, FontStyle.Bold), Brushes.DarkCyan, 280, 30);

            if (File.Exists(Laundry.ImagePath))
            e.Graphics.DrawImage(Image.FromFile(Laundry.ImagePath), 400, 70,100,100);

            e.Graphics.DrawString(
                "\n\n" + Laundry.Name + "\t\t" + Laundry.Phone
                + "\n\t" + Laundry.Address
                + "\nOrder Number : " + _OrderID.ToString()
                + "\nCustomer : " + Order.Person.FirstName 
                + "\nDate : " + Order.OrderDate 
                + "\nWashing Time : " + Order.WashingString() 
                , new Font("Arial", 16, FontStyle.Regular), Brushes.Black, 300, 120);
           
            e.Graphics.FillRectangle(blueBrush, rect);

            e.Graphics.DrawString("Items Name", new Font("Poppins", 18, FontStyle.Regular), Brushes.White, 25, 360);

            e.Graphics.DrawString("Items Price", new Font("Poppins", 18, FontStyle.Regular), Brushes.White, 400, 360);

            e.Graphics.DrawString("Qty", new Font("Poppins", 18, FontStyle.Regular), Brushes.White, 600, 360);

            DataTable dtOrderItems = clsOrderItems.GetBillInfo(_OrderID);

            int i = 400;

            foreach (DataRow dr in dtOrderItems.Rows)
            {
                e.Graphics.DrawString(dr[0].ToString(), new Font("Poppins", 18, FontStyle.Regular), Brushes.Black, 25, i);

                e.Graphics.DrawString(dr[1].ToString(), new Font("Poppins", 18, FontStyle.Regular), Brushes.Black, 400, i);

                e.Graphics.DrawString(dr[2].ToString(), new Font("Poppins", 18, FontStyle.Regular), Brushes.Black, 600, i);

                i += 50;
            }

             rect = new Rectangle(0, i, 1000, 50);

            e.Graphics.FillRectangle(blueBrush, rect);

            e.Graphics.DrawString("Total : " + Order.OrderPrice.ToString() + "\t\t" + "Paid  : " +
                Order.CustomerPaid.ToString() , new Font("Poppins", 18, FontStyle.Regular), Brushes.White, 300, i);

            i += 50;

            QRCodeGenerator qRCode = new QRCodeGenerator();

            QRCodeData Data = qRCode.CreateQrCode(Order.OrderID.ToString(),QRCodeGenerator.ECCLevel.L);

            QRCode Code = new QRCode(Data);

            e.Graphics.DrawImage(Code.GetGraphic(5), 300, i, 250, 250);


        }
    }
}
