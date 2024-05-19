namespace Washing_App.Items
{
    partial class frmAddEditItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.pcItemPicture = new System.Windows.Forms.PictureBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(11, 372);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(138, 38);
            this.btSave.TabIndex = 38;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(104, 176);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(126, 36);
            this.llSetImage.TabIndex = 41;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked_1);
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.Location = new System.Drawing.Point(115, 212);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(104, 36);
            this.llRemove.TabIndex = 40;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked_1);
            // 
            // pcItemPicture
            // 
            this.pcItemPicture.Location = new System.Drawing.Point(67, 74);
            this.pcItemPicture.Name = "pcItemPicture";
            this.pcItemPicture.Size = new System.Drawing.Size(197, 99);
            this.pcItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcItemPicture.TabIndex = 39;
            this.pcItemPicture.TabStop = false;
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(165, 372);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 38);
            this.btCancel.TabIndex = 37;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Price:";
            // 
            // txPrice
            // 
            this.txPrice.Location = new System.Drawing.Point(67, 315);
            this.txPrice.Name = "txPrice";
            this.txPrice.Size = new System.Drawing.Size(236, 24);
            this.txPrice.TabIndex = 35;
            this.txPrice.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name :";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(67, 258);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(236, 24);
            this.txName.TabIndex = 33;
            this.txName.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(49, 10);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(229, 50);
            this.lbTitle.TabIndex = 32;
            this.lbTitle.Text = "Add New Item";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddEditItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(313, 423);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.pcItemPicture);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEditItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditItem";
            this.Load += new System.EventHandler(this.frmAddEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.PictureBox pcItemPicture;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}