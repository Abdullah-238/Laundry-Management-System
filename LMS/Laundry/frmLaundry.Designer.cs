namespace Washing_App
{
    partial class frmLaundry
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txLaundryName = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbcLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(38, 434);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(138, 38);
            this.btSave.TabIndex = 25;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(221, 434);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 38);
            this.btCancel.TabIndex = 24;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Phone :";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(153, 192);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(236, 24);
            this.txPhone.TabIndex = 22;
            this.txPhone.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address :";
            // 
            // txAddress
            // 
            this.txAddress.Location = new System.Drawing.Point(153, 135);
            this.txAddress.Name = "txAddress";
            this.txAddress.Size = new System.Drawing.Size(236, 24);
            this.txAddress.TabIndex = 20;
            this.txAddress.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Laundry Name :";
            // 
            // txLaundryName
            // 
            this.txLaundryName.Location = new System.Drawing.Point(153, 78);
            this.txLaundryName.Name = "txLaundryName";
            this.txLaundryName.Size = new System.Drawing.Size(236, 24);
            this.txLaundryName.TabIndex = 18;
            this.txLaundryName.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(59, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(282, 50);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Add New Laundry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Logo :";
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.Location = new System.Drawing.Point(32, 332);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(104, 36);
            this.llRemove.TabIndex = 28;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llSetImage.Location = new System.Drawing.Point(21, 296);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(126, 36);
            this.llSetImage.TabIndex = 29;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "Set Image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbcLogo
            // 
            this.pbcLogo.Location = new System.Drawing.Point(153, 247);
            this.pbcLogo.Name = "pbcLogo";
            this.pbcLogo.Size = new System.Drawing.Size(236, 151);
            this.pbcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcLogo.TabIndex = 27;
            this.pbcLogo.TabStop = false;
            // 
            // frmLaundry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 505);
            this.Controls.Add(this.llSetImage);
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.pbcLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txLaundryName);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLaundry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLaundry";
            this.Load += new System.EventHandler(this.frmLaundry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txLaundryName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.PictureBox pbcLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}