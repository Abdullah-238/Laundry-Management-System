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

namespace Washing_App.Order
{
    public partial class ucOrder : UserControl
    {
        public event EventHandler OnSelect = null;  

        clsItem _Item;
       
        public string name
        {
            get
            {
                return lbName.Text;
            }
        }

        public decimal Price
        {
            get
            {
                return _Item.ItemPrice;
            }
        }

        public int ID
        {
            get
            {
                return _Item.ItemID;
            }
        }
        public ucOrder()
        {
            InitializeComponent();
        }
        public void FillProudectINfo(int ItemID)
        {
            _Item = clsItem.Find(ItemID);

            if (_Item == null)
            {
                MessageBox.Show("Items not found", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      

            lbName.Text = _Item.ItemName;

            if (_Item.ImagePath != "")
            pcProudctImage.ImageLocation = _Item.ImagePath; 
            else
                pcProudctImage.ImageLocation = null;
        }

        private void pcProudctImage_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
