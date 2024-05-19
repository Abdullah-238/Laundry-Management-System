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
    public partial class frmReport : Form
    {
        static DataTable _dtAll = clsReportes.GetAllTotalAndPaid();
        public frmReport()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _CalculteIncomeAndOutCome()
        {
            decimal Total = Convert.ToDecimal(_dtAll.Compute("Sum(Total)", string.Empty));
            txTotal.Text = Total.ToString();

            decimal Paid = Convert.ToDecimal(_dtAll.Compute("Sum(Paid)", string.Empty));
            txPaid.Text = Paid.ToString();

            decimal Remain = Paid - Total;

            if (Remain < 0)
                txRemaining.BackColor = Color.Red;
            else if (Remain == 0)
                txRemaining.BackColor = Color.Blue;
            else
                txRemaining.BackColor = Color.Green;

            txRemaining.Text = Remain.ToString();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            _CalculteIncomeAndOutCome();
        }
    }
}
