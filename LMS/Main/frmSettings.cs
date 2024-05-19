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
using Washing_App.Laundry;
using Washing_App.Reprots;
using Washing_App.User;

namespace Washing_App
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private void btUsers_Click(object sender, EventArgs e)
        {

            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.enPermissions.eMangeItems))
            {
                MessageBox.Show("This user doesn't have acess to this " +
                    "screen please contact your admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmItemsList Items = new frmItemsList();

            Items.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.enPermissions.eMangeUsers))
            {
                MessageBox.Show("This user doesn't have acess to this " +
                    "screen please contact your admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmUserList UserList = new frmUserList();

            UserList.ShowDialog();

            frmSettings_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.enPermissions.eMangeLaundry))
            {
                MessageBox.Show("This user doesn't have acess to this " +
                    "screen please contact your admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmLaundryList Laundry = new frmLaundryList();

            Laundry.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.enPermissions.eMangeReportes))
            {
                MessageBox.Show("This user doesn't have acess to this " +
                    "screen please contact your admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmReport Report = new frmReport();

            Report.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.CheckAccessPermissions(clsUsers.enPermissions.eMangeLaundry))
            {
                MessageBox.Show("This user doesn't have acess to this " +
                    "screen please contact your admin", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmSelectDefaultLaundry defaultLaundry = new frmSelectDefaultLaundry();

            defaultLaundry.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReportesByDate reportesByDate = new frmReportesByDate();

            reportesByDate.ShowDialog();


        }
    }
}
