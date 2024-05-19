using LMS_BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washing_App.Items;

namespace Washing_App
{
    public partial class frmItemsList : Form
    {
        static DataTable _dtItems = clsItem.GetAllItems();

        static DataTable _dtAllItems = _dtItems.DefaultView.ToTable(false,
            "ItemID", "ItemName", "ItemPrice");

        public frmItemsList()
        {
            InitializeComponent();
        }

        void _RefreshList()
        {
            _dtItems = clsItem.GetAllItems();

            _dtAllItems = _dtItems.DefaultView.ToTable(false, "ItemID", "ItemName", "ItemPrice");

            dgvItems.DataSource = _dtAllItems;

            lbNumberOfUsers.Text = dgvItems.RowCount.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;

            dgvItems.DataSource = _dtAllItems;

            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Columns[0].HeaderText = "Item ID";
                dgvItems.Columns[0].Width = 100;

                dgvItems.Columns[1].HeaderText = "Item Name";
                dgvItems.Columns[1].Width = 300;

                dgvItems.Columns[2].HeaderText = "Item Price";
                dgvItems.Columns[2].Width = 150;
            }
            lbNumberOfUsers.Text = dgvItems.RowCount.ToString();     
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {

            string FilterValue = "";

            switch (cbFilterBy.SelectedItem)
            {
                case "None":
                    FilterValue = "None";
                    break;
                case "Item ID":
                    FilterValue = "ItemID";
                    break;
                case "Item Name":
                    FilterValue = "ItemName";
                    break;
                case "Item Price":
                    FilterValue = "ItemPrice";
                    break;
              
            }

            if (txSearch.Text == "" || FilterValue == "None")
            {
                _dtAllItems.DefaultView.RowFilter = "";
                lbNumberOfUsers.Text = dgvItems.RowCount.ToString();
                return;
            }

            if (FilterValue == "ItemID" || FilterValue == "ItemPrice")
            {
                _dtAllItems.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterValue, txSearch.Text.Trim());
                lbNumberOfUsers.Text = dgvItems.RowCount.ToString();
            }
            else
            {
                _dtAllItems.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txSearch.Text.Trim());
                lbNumberOfUsers.Text = dgvItems.RowCount.ToString();
            }

        }

        private void txSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Item ID" || cbFilterBy.Text == "Item Price")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None" )
                txSearch.Visible = false;
            else
                txSearch.Visible = true;
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemID = (int)dgvItems.CurrentRow.Cells[0].Value;

            frmAddEditItems AddUpdateItems = new frmAddEditItems(ItemID);

            AddUpdateItems.ShowDialog();

            _RefreshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ItemID = (int)dgvItems.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure want to delete this Item ?", "Warning"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsItem.DeleteItem(ItemID))
                {
                    MessageBox.Show("Item deleted successfully",
                        "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshList();
                }
                else
                {
                    MessageBox.Show("Item deleted failed",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditItems AddUpdateItems = new frmAddEditItems();

            AddUpdateItems.ShowDialog();

            _RefreshList();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditItems AddUpdateItems = new frmAddEditItems();

            AddUpdateItems.ShowDialog();

            _RefreshList();

        }
    }
}
