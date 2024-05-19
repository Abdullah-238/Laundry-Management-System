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

namespace Washing_App.Laundry
{
    public partial class frmLaundryList : Form
    {
        static DataTable _dtLaundries = clsLaundry.GetAllLuandry();

        static DataTable _dtAllLaundries = _dtLaundries.DefaultView.ToTable(false, "LuandryID",
                "Name", "Address", "Phone");
        public frmLaundryList()
        {
            InitializeComponent();
        }

        void _RefreshList()
        {
            _dtLaundries = clsLaundry.GetAllLuandry();

            _dtAllLaundries = _dtLaundries.DefaultView.ToTable(false, "LuandryID",
                "Name", "Address", "Phone");

            dgvLuandries.DataSource = _dtAllLaundries;
           
        }


        private void frmLaundryList_Load(object sender, EventArgs e)
        {
           DataTable dtLaundries = clsLaundry.GetAllLuandry();

            dgvLuandries.DataSource = _dtAllLaundries;
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LaundryID = (int)dgvLuandries.CurrentRow.Cells[0].Value;

            frmLaundry UpdateLaundt = new frmLaundry(LaundryID);

            UpdateLaundt.ShowDialog();

            _RefreshList();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLaundry UpdateLaundt = new frmLaundry();

            UpdateLaundt.ShowDialog();

            _RefreshList();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddNewItem_Click(object sender, EventArgs e)
        {
            frmLaundry UpdateLaundt = new frmLaundry();

            UpdateLaundt.ShowDialog();

            _RefreshList();
        }
    }
}
