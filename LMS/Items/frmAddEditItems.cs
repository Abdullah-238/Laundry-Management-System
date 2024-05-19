using LMS_BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Washing_App.Properties;

namespace Washing_App.Items
{
    public partial class frmAddEditItems : Form
    {
        clsItem Item;
        enum enMode { AddNewItem, UpdateItem };

        enMode Mode;

        int _ItemID = 0;
        public frmAddEditItems()
        {
            InitializeComponent();

            Mode = enMode.AddNewItem;
        }

        public frmAddEditItems(int ItemID)
        {
            InitializeComponent();

            Mode = enMode.UpdateItem;

            _ItemID = ItemID;
        }

        void _LoadData()
        {
            Item = clsItem.Find(_ItemID);

            if (Item == null)
            {
                MessageBox.Show("This Item with " + _ItemID + "is not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txName.Text = Item.ItemName;
            txPrice.Text = Item.ItemPrice.ToString();

            _LoadItemImage();
        }

        void _LoadItemImage()
        {

            string ImagePath = Item.ImagePath; 

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pcItemPicture.ImageLocation = Item.ImagePath;
                else 
                MessageBox.Show("Image not found path : " +  ImagePath  ,
                    "Error",MessageBoxButtons.OK ,MessageBoxIcon.Error);
            
        }

        void _ResetDefaultValue()
        {
            if (Mode == enMode.AddNewItem)
            {
                llRemove.Visible = false;
                lbTitle.Text = "Add New Item";
                this.Text = "Add New Item";
                Item = new clsItem();
            }
            else
            {
                lbTitle.Text = "Update New Item";
                this.Text = "Update New Item";
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

        private void frmAddEditItem_Load(object sender, EventArgs e)
        {
            _ResetDefaultValue();

            if (Mode == enMode.UpdateItem)
                _LoadData();
        }

        private void llRemove_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pcItemPicture.Image = Resources.clothes;
            llRemove.Visible = false;
        }

        private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pcItemPicture.Load(selectedFilePath);
                llRemove.Visible = true;
            }
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Feilds are empty , Please Fill All required Feilds to continue",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Item.ItemName = txName.Text;
            Item.ItemPrice = Convert.ToDecimal(txPrice.Text);
            if (pcItemPicture.ImageLocation == null)
            {
                MessageBox.Show("Please select a Picture",
                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            Item.ImagePath = pcItemPicture.ImageLocation;


            if (Item.Save())
            {
                MessageBox.Show("Data Saved Succesfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Faild", "Errorr", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }
    }
}
