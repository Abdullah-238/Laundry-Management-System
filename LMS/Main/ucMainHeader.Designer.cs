namespace Washing_App.Main
{
    partial class ucMainHeader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUser = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUser.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Location = new System.Drawing.Point(0, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(59, 30);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDate.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(549, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(59, 30);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "label1";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTime.Font = new System.Drawing.Font("Poppins Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(490, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(59, 30);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "label1";
            // 
            // ucMainHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbUser);
            this.Name = "ucMainHeader";
            this.Size = new System.Drawing.Size(608, 35);
            this.Load += new System.EventHandler(this.ucMainHeader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
    }
}
