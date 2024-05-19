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
    public partial class frmSelectDefaultLaundry : Form
    {
        public frmSelectDefaultLaundry()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLaundry laundry = new frmLaundry();

            laundry.ShowDialog();

        }

        void _LoadLaundries()
        {

            DataTable dt = clsLaundry.GetAllLuandry();

            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["Name"]);
            }


            if (clsGlobal.CurrentLaundry != null)
            comboBox1.SelectedItem = clsGlobal.CurrentLaundry.Name; 

        }

        private void frmSelectDefaultLaundry_Load(object sender, EventArgs e)
        {
            _LoadLaundries();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string LaundryName = comboBox1.SelectedItem.ToString(); 


            clsGlobal.SaveLaundryNameInFile(LaundryName);

            clsGlobal.CurrentLaundry = clsLaundry.Find(LaundryName);
           
            MessageBox.Show("Default Laundry saved succefully", "Done", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
