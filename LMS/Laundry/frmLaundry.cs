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
using Washing_App.Global;
using Washing_App.Properties;

namespace Washing_App
{
    public partial class frmLaundry : Form
    {
        clsLaundry _Laundry;
        enum enMode { AddNewLaundry, UpdateLaundry };

        enMode Mode;

        int _LaundryID = 0;
        public frmLaundry()
        {
            InitializeComponent();

            Mode = enMode.AddNewLaundry;
        }

        public frmLaundry(int _UserID)
        {
            InitializeComponent();

            Mode = enMode.UpdateLaundry;

            _LaundryID = _UserID;
        }

        bool _HandleImage()
        {
            if (pbcLogo.ImageLocation != _Laundry.ImagePath)
            {
                if (_Laundry.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_Laundry.ImagePath);
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                if (pbcLogo.ImageLocation != null)
                {
                    if (pbcLogo.ImageLocation != null)
                    {
                        string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                        string DestinationFolder = currentDirectory + @"-Images\";

                        string SourceImageFile = pbcLogo.ImageLocation.ToString();

                        if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile, DestinationFolder))
                        {
                            pbcLogo.ImageLocation = SourceImageFile;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error Copying Image File", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }

                }
            }
            return true;

        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (!_HandleImage())
                return; 

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Feilds are empty , Please Fill All required Feilds to continue",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandleImage())
                return;

            _Laundry.Name    = txLaundryName.Text;
            _Laundry.Address = txAddress.Text;
            _Laundry.Phone   = txPhone.Text;

            if (pbcLogo.ImageLocation != null)
            _Laundry.ImagePath =  pbcLogo.ImageLocation.ToString();



            if (_Laundry.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Done", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Saved Failed", "Error", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

         
        }


        void _LoadData()
        {
            _Laundry = clsLaundry.Find(_LaundryID);

            if (_Laundry == null)
            {
                MessageBox.Show("This Luandri with " + _LaundryID + "is not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            txAddress.Text = _Laundry.Address;
            txLaundryName.Text = _Laundry.Name;
            txPhone.Text = _Laundry.Phone;

           
            _LoadItemImage();
        }

        void _LoadItemImage()
        {

            string ImagePath = _Laundry.ImagePath;

            if (ImagePath != "")
                if (File.Exists(ImagePath))
                {
                    pbcLogo.ImageLocation = _Laundry.ImagePath;
                    llRemove.Visible = true;
                }
                else
                    MessageBox.Show("Image not found path : " + ImagePath,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void _ResetDefaultValue()
        {
            btSave.Focus();

            if (Mode == enMode.AddNewLaundry)
            {
                lbTitle.Text = "Add New Laundry";
                this.Text = "Add New Laundry";

                llRemove.Visible = false;
                pbcLogo.Image = Resources.warehouse;
                _Laundry = new clsLaundry();

            }
            else
            {
                lbTitle.Text = "Update New Laundry";
                this.Text = "Update New Laundry";
            }
        }
        private void frmLaundry_Load(object sender, EventArgs e)
        {

            _ResetDefaultValue();

            if (Mode == enMode.UpdateLaundry)
                _LoadData();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

            this.Close();

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

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                pbcLogo.Load(selectedFilePath);
                llRemove.Visible = true;
                // ...
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbcLogo.Image = Resources.warehouse; ;
            llRemove.Visible = false;
        }
    }
}
