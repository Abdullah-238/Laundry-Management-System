using LMS_BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washing_App.Order.Order;

namespace Washing_App
{

    public partial class frmCompleteOrder : Form
    {
        int _OrderID = 0;

        clsOrders _Order;
        public frmCompleteOrder()
        {
            InitializeComponent();
        }

        void _LoadInfo()
        {
           
            if (_Order.OrderStatus == clsOrders.enStatus.eCompleted)
            {
                MessageBox.Show("this order is already completed", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txOrderNumber.Text))
            {
                txOrderNumber.Text = _OrderID.ToString();
            }

            decimal Remaining = _Order.OrderPrice - _Order.CustomerPaid;

            lbTotal.Text = _Order.OrderPrice.ToString();
            lbPaid.Text = _Order.CustomerPaid.ToString();
            lbRemaing.Text = Remaining.ToString();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please enter a number" , "Error" , MessageBoxButtons.OK,
                    MessageBoxIcon.Error);    
                return; 
            }

            _OrderID = int.Parse(txOrderNumber.Text.Trim());

            _Order = clsOrders.Find(_OrderID);

            if (_Order == null)
            {
                MessageBox.Show("Please enter a valid Order Number", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _LoadInfo();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (int.Parse(txRemaing.Text.Trim()) != int.Parse(lbRemaing.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid Amount" , "Error",MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return; 
            }
            else
            {
                _Order.OrderStatus = clsOrders.enStatus.eCompleted;  ;
                _Order.CustomerPaid = int.Parse(txRemaing.Text);

                if (_Order.Save())
                {
                    MessageBox.Show("Order Compelted", "Done", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Order not Compelt", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }
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

        private void frmCompleteOrder_Load(object sender, EventArgs e)
        {
            txOrderNumber.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            frmOpenCamera OpenCamera = new frmOpenCamera();

            OpenCamera.DataBack += OpenCamera_DataBack;

            OpenCamera.ShowDialog();

        }

        private void OpenCamera_DataBack(object sender, int OrderID)
        {
           _OrderID = OrderID;

            _Order = clsOrders.Find(_OrderID);


            if (_Order == null)
            {
                MessageBox.Show("Please enter a valid Order Number",
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _LoadInfo();
        }
    }
}
