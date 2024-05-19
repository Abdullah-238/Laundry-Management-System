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
using Washing_App.User;

namespace Washing_App
{
    public partial class frmMain : Form
    {
        frmLogin _Login; 
        public frmMain(frmLogin Login)
        {
            InitializeComponent();

            _Login = Login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewOrders frmNewOrder = new NewOrders();

            frmNewOrder.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser    = null; 
            clsGlobal.CurrentLaundry = null;

            this.Close();

            _Login.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSettings Settings = new frmSettings();

            Settings.ShowDialog();
        }

      

        private void btUsers_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmUserList UserList = new frmUserList();

            UserList.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmLaundryList Laundry = new frmLaundryList();

            Laundry.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCompleteOrder completeOrder = new frmCompleteOrder();

            completeOrder.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            frmSelectDefaultLaundry defaultLaundry = new frmSelectDefaultLaundry();

            defaultLaundry.ShowDialog();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ucMainHeader1.LoadInfo();

            string LaundryName = "";

            clsGlobal.GetStoredLaundry(ref LaundryName);

            clsGlobal.CurrentLaundry = clsLaundry.Find(LaundryName);
        }
    }
}
