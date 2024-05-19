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

namespace Washing_App
{
    public partial class frmAddUpdateUser : Form
    {
        clsUsers User;

        enum enMode { AddNewUser , UpdateUser};

        enMode Mode;

        int _UserID = 0;
        public frmAddUpdateUser()
        {
            InitializeComponent();

            Mode = enMode.AddNewUser;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();

            Mode = enMode.UpdateUser;

            _UserID = UserID; 
        }

        private void _MangePermissions()
        {
            if (User.Permission == clsUsers.enPermissions.eAll)
            {
                ckAllPermissions.Checked = true;
            }
            else
            {
                if ((User.Permission & clsUsers.enPermissions.eMangeUsers) ==
                  clsUsers.enPermissions.eMangeUsers)
                    ckListPermissions.SetItemChecked(0, true);

                if ((User.Permission & clsUsers.enPermissions.eMangeItems) ==
                       clsUsers.enPermissions.eMangeItems)
                    ckListPermissions.SetItemChecked(1, true);

                if ((User.Permission & clsUsers.enPermissions.eMangeLaundry) ==
                       clsUsers.enPermissions.eMangeLaundry)
                    ckListPermissions.SetItemChecked(2, true);

                if ((User.Permission & clsUsers.enPermissions.eMangeReportes) ==
                       clsUsers.enPermissions.eMangeReportes)
                    ckListPermissions.SetItemChecked(3, true);
            }

        }

        void _LoadData()
        {
            User = clsUsers.Find(_UserID);

            if (User == null)
            {
                MessageBox.Show("This user with " + _UserID + "is not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            txFirstName.Text = User.FirstName;
            txLastName.Text = User.LastName; 
            txPhone.Text = User.Phone;
            txUserName.Text = User.UserName;
            ckIsActive.Checked = User.IsActive;

            _MangePermissions();
        }

        void _UncheckAllItems()
        {
            for (byte i = 0; i < ckListPermissions.Items.Count; i++ )
            {
                ckListPermissions.SetItemChecked(i, false);
            }
        }

        void _ResetDefaultValue()
        {
            if (Mode == enMode.AddNewUser)
            {
                lbTitle.Text = "Add New User";
                this.Text = "Add New User";
                User = new clsUsers();
            }
            else
            {
                lbTitle.Text = "Update New User";
                this.Text = "Update New User";
            }

            ckAllPermissions.Checked = false;
            _UncheckAllItems();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (Mode == enMode.UpdateUser)
                _LoadData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Feilds_Validating_PassWord(object sender, CancelEventArgs e)
        {
            TextBox Txt = (TextBox)sender;
            if (string.IsNullOrEmpty(Txt.Text.Trim()) && Mode != enMode.UpdateUser)
            {
                e.Cancel = true;
                errorProvider1.SetError(Txt, "This field shouldn't be empty");
            }
            else
            {
                errorProvider1.SetError(Txt, "");
            }
        }

        private void Feilds_Validating(object sender, CancelEventArgs e)
        {
            TextBox Txt = (TextBox)sender;
            if (string.IsNullOrEmpty(Txt.Text.Trim()))
            {
                e.Cancel = true; 
                errorProvider1.SetError(Txt, "This field shouldn't be empty");
            }
            else
            {
                errorProvider1.SetError(Txt, "");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (clsUsers.IsUserNameFound(txUserName.Text.Trim()) && Mode == enMode.AddNewUser)
            {
                errorProvider1.SetError(txUserName, "this User Name is Exsist please enter anthor one");
            }
            else
            {
                errorProvider1.SetError(txUserName, "");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAllPermissions.Checked)
            {
                _UncheckAllItems();
                ckListPermissions.Enabled = false; 
            }
            else
                ckListPermissions.Enabled = true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Feilds are empty , Please Fill All required Feilds to continue",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txConfrimPassword.Text != txPassword.Text && Mode == enMode.AddNewUser)
            {
                MessageBox.Show("Password Not Match",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUsers.IsUserNameFound(txUserName.Text) && Mode == enMode.AddNewUser)
            {
                MessageBox.Show("this User Name is Exsist please enter anthor one",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            User.FirstName = txFirstName.Text;
            User.LastName = txLastName.Text;
            User.Phone = txPhone.Text;
            User.UserName = txUserName.Text;
            User.IsActive = ckIsActive.Checked;

            string Password = clsGlobal.ComputeHash(txPassword.Text);

            if (string.IsNullOrEmpty(txPassword.Text))
                User.Password = User.Password;
            else
                User.Password = Password;



            if (ckAllPermissions.Checked)
                User.Permission = clsUsers.enPermissions.eAll;
            else
            {

                int permissions = 0;

                if (ckListPermissions.GetItemChecked(0))
                    permissions = (int)clsUsers.enPermissions.eMangeUsers;

                if (ckListPermissions.GetItemChecked(1))
                    permissions += (int)clsUsers.enPermissions.eMangeItems;

                if (ckListPermissions.GetItemChecked(2))
                    permissions += (int)clsUsers.enPermissions.eMangeLaundry;

                if (ckListPermissions.GetItemChecked(3))
                    permissions += (int)clsUsers.enPermissions.eMangeReportes;

               
                User.Permission = (clsUsers.enPermissions)permissions;

            }



            if (User.Save())
            {
                _UserID = User.UserID;
                MessageBox.Show("Data Saved Succesfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _LoadData();
            }
            else
            {
                MessageBox.Show("Data Saved Faild", "Errorr", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

    }
}
