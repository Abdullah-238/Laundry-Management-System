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

namespace Washing_App.User
{
    public partial class frmUserList : Form
    {
        static DataTable _dtAllUsers = clsUsers.GetAllUsers();

        static DataTable _dtUsers = 
            _dtAllUsers.DefaultView.ToTable(false,"UserID", "FullName", "UserName", "IsActive");
        public frmUserList()
        {
            InitializeComponent();
        }

        void _RefreshList()
        {
                _dtAllUsers = clsUsers.GetAllUsers();
                
                _dtUsers =
                _dtAllUsers.DefaultView.ToTable(false, "UserID", "FullName", "UserName", "IsActive");

                dgvUsers.DataSource = _dtUsers;

               lbNumberOfUsers.Text = dgvUsers.RowCount.ToString();
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbIsActive.SelectedIndex = 0; 

            dgvUsers.DataSource = _dtUsers;

            if (dgvUsers.Rows.Count > 0 )
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 100;

                dgvUsers.Columns[1].HeaderText = "Full Name";
                dgvUsers.Columns[1].Width = 300;

                dgvUsers.Columns[2].HeaderText = "User Name";
                dgvUsers.Columns[2].Width = 150;

                dgvUsers.Columns[3].HeaderText = "Is Active";
                dgvUsers.Columns[3].Width = 100;
            }
            lbNumberOfUsers.Text = dgvUsers.RowCount.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser addUpdateUser = new frmAddUpdateUser();

            addUpdateUser.ShowDialog();

            _RefreshList();
        }

        private void txSearch_TextChanged(object sender, EventArgs e)
        {

            string FilterValue = "";

            switch (cbFilterBy.SelectedItem)
            {
                case "None":
                    FilterValue = "None";
                    break;
                case "User ID":
                    FilterValue = "UserID";
                    break;
                case "Full Name":
                    FilterValue = "FullName";
                    break;
                case "User Name":
                    FilterValue = "UserName";
                    break;
                case "Is Active":
                    FilterValue = "IsActive";
                    break;
            }

            if (txSearch.Text == "" || FilterValue == "None")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lbNumberOfUsers.Text = dgvUsers.RowCount.ToString();
                return; 
            }

            if (FilterValue == "UserID" )
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterValue , txSearch.Text.Trim());

            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterValue, txSearch.Text.Trim());


            lbNumberOfUsers.Text = dgvUsers.RowCount.ToString();

        }

        private void txSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbFilterBy.Text == "None" || cbFilterBy.Text == "Is Active")
            {
                txSearch.Visible = false;

                if (cbFilterBy.Text == "Is Active")
                    cbIsActive.Visible = true;

            }
            else
            {

                txSearch.Visible = true;
            }

        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterValue = "";

            string FilterColumn = "IsActive";

            FilterValue = cbIsActive.Text.Trim();

            switch(FilterValue)
            {
                case "None":
                    break;
                case "Active":
                    FilterValue = "1";
                    break;
                case "InActive":
                    FilterValue = "0";
                    break;

            }


            if (FilterValue == "None")
                _dtUsers.DefaultView.RowFilter = "";
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID =(int) dgvUsers.CurrentRow.Cells[0].Value;

            frmAddUpdateUser addUpdateUser = new frmAddUpdateUser(UserID);

            addUpdateUser.ShowDialog();

            _RefreshList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

           if (MessageBox.Show("Are you sure want to delete this user ?" , "Warning"
               , MessageBoxButtons.OKCancel
               , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser(UserID))
                {
                    MessageBox.Show("User deleted successfully", 
                        "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User deleted failed",
                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser addUpdateUser = new frmAddUpdateUser();

            addUpdateUser.ShowDialog();

            _RefreshList();
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            _dtUsers.DefaultView.Sort = "FullName desc";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _dtUsers.DefaultView.Sort = "FullName Asc";
        }
    }
}
