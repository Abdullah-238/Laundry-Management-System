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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            clsUsers User = clsUsers.FindByUserNameAndPassword(txUserName.Text.Trim(),
                clsGlobal.ComputeHash(txPassword.Text));


            if (User != null)
            {

                if (ckbRemberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txUserName.Text, txPassword.Text);
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                if (!User.IsActive)
                {
                    MessageBox.Show("This user is inactive please connect you admin" , "User InActive" ,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.CurrentUser = User;

                this.Hide();

                frmMain menu = new frmMain(this);

                menu.Show();

            }
            else
            {
                MessageBox.Show("User name or Password is not correct please try again" , "Error" , 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

 
        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            string UserName = ""; string Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txUserName.Text = UserName;

                txPassword.Text = Password;

                ckbRemberMe.Checked = true;
            }

            else ckbRemberMe.Checked = false;


        }
    }
}
