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

namespace Washing_App.Reprots
{
    public partial class frmReportesByDate : Form
    {
        public frmReportesByDate()
        {
            InitializeComponent();
        }

        void SelectDate ()
        {
            short Year = (short)dateTimePicker1.Value.Year;
            short Month = (short)dateTimePicker1.Value.Month;
            short Day = (short)dateTimePicker1.Value.Day;

            dgvOrdersList.DataSource =  clsReportes.GetReportesByDate (Year , Month , Day);

            if (dgvOrdersList.Columns.Count > 0)
            {
                dgvOrdersList.Columns[0].Width = 60;
                dgvOrdersList.Columns[1].Width = 60;
                dgvOrdersList.Columns[2].Width = 60;
                dgvOrdersList.Columns[3].Width = 60;
                dgvOrdersList.Columns[4].Width = 85;
                dgvOrdersList.Columns[5].Width = 85;
                dgvOrdersList.Columns[6].Width = 85;
                dgvOrdersList.Columns[7].Width = 185;
                dgvOrdersList.Columns[8].Width = 85;
                dgvOrdersList.Columns[9].Width = 85;
            }
        }

        private void frmReportesByDate_Load(object sender, EventArgs e)
        {
            SelectDate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SelectDate();

        }
    }
}
