namespace Washing_App
{
    partial class frmAddUpdateUser
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txConfrimPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckIsActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TextBox5 = new System.Windows.Forms.Label();
            this.txUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ckAllPermissions = new System.Windows.Forms.CheckBox();
            this.ckListPermissions = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(109, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 50);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add New User";
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(159, 87);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(236, 24);
            this.txFirstName.TabIndex = 1;
            this.txFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name :";
            // 
            // txLastName
            // 
            this.txLastName.Location = new System.Drawing.Point(159, 144);
            this.txLastName.Name = "txLastName";
            this.txLastName.Size = new System.Drawing.Size(236, 24);
            this.txLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone :";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(159, 201);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(236, 24);
            this.txPhone.TabIndex = 5;
            this.txPhone.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(257, 592);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(138, 38);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(52, 592);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(138, 38);
            this.btSave.TabIndex = 8;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confrim Password :";
            // 
            // txConfrimPassword
            // 
            this.txConfrimPassword.Location = new System.Drawing.Point(159, 373);
            this.txConfrimPassword.MaxLength = 12;
            this.txConfrimPassword.Name = "txConfrimPassword";
            this.txConfrimPassword.PasswordChar = '*';
            this.txConfrimPassword.Size = new System.Drawing.Size(236, 24);
            this.txConfrimPassword.TabIndex = 9;
            this.txConfrimPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating_PassWord);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Is Active :";
            // 
            // ckIsActive
            // 
            this.ckIsActive.AutoSize = true;
            this.ckIsActive.Location = new System.Drawing.Point(159, 555);
            this.ckIsActive.Name = "ckIsActive";
            this.ckIsActive.Size = new System.Drawing.Size(85, 21);
            this.ckIsActive.TabIndex = 12;
            this.ckIsActive.Text = "Is Active ";
            this.ckIsActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password :";
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(159, 316);
            this.txPassword.MaxLength = 12;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(236, 24);
            this.txPassword.TabIndex = 13;
            this.txPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating_PassWord);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TextBox5
            // 
            this.TextBox5.AutoSize = true;
            this.TextBox5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox5.Location = new System.Drawing.Point(53, 256);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(91, 23);
            this.TextBox5.TabIndex = 16;
            this.TextBox5.Text = "User Name :";
            // 
            // txUserName
            // 
            this.txUserName.Location = new System.Drawing.Point(159, 256);
            this.txUserName.Name = "txUserName";
            this.txUserName.Size = new System.Drawing.Size(236, 24);
            this.txUserName.TabIndex = 15;
            this.txUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txUserName.Validating += new System.ComponentModel.CancelEventHandler(this.Feilds_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Permissions :";
            // 
            // ckAllPermissions
            // 
            this.ckAllPermissions.AutoSize = true;
            this.ckAllPermissions.Location = new System.Drawing.Point(159, 425);
            this.ckAllPermissions.Name = "ckAllPermissions";
            this.ckAllPermissions.Size = new System.Drawing.Size(153, 21);
            this.ckAllPermissions.TabIndex = 20;
            this.ckAllPermissions.Text = "Access to all screens";
            this.ckAllPermissions.UseVisualStyleBackColor = true;
            this.ckAllPermissions.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckListPermissions
            // 
            this.ckListPermissions.FormattingEnabled = true;
            this.ckListPermissions.Items.AddRange(new object[] {
            "Mange User",
            "Mange Items ",
            "Mange Laundry",
            "Mange Reportes"});
            this.ckListPermissions.Location = new System.Drawing.Point(157, 457);
            this.ckListPermissions.Name = "ckListPermissions";
            this.ckListPermissions.Size = new System.Drawing.Size(236, 80);
            this.ckListPermissions.TabIndex = 22;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 649);
            this.Controls.Add(this.ckListPermissions);
            this.Controls.Add(this.ckAllPermissions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.txUserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.ckIsActive);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txConfrimPassword);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txFirstName);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPhone;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txConfrimPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckIsActive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label TextBox5;
        private System.Windows.Forms.TextBox txUserName;
        private System.Windows.Forms.CheckBox ckAllPermissions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox ckListPermissions;
    }
}

