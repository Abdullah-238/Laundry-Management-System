namespace Washing_App.Order
{
    partial class ucOrder
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
            this.lbName = new System.Windows.Forms.Label();
            this.pcProudctImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcProudctImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(54, 162);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(59, 30);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // pcProudctImage
            // 
            this.pcProudctImage.Image = global::Washing_App.Properties.Resources.washing_machine__1_;
            this.pcProudctImage.Location = new System.Drawing.Point(21, 20);
            this.pcProudctImage.Name = "pcProudctImage";
            this.pcProudctImage.Size = new System.Drawing.Size(130, 94);
            this.pcProudctImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcProudctImage.TabIndex = 2;
            this.pcProudctImage.TabStop = false;
            this.pcProudctImage.Click += new System.EventHandler(this.pcProudctImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-21, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ــــــــــــــــــــــــــــــــــــــــــــــــــــــــ";
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcProudctImage);
            this.Controls.Add(this.lbName);
            this.Size = new System.Drawing.Size(172, 202);
            ((System.ComponentModel.ISupportInitialize)(this.pcProudctImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pcProudctImage;
        private System.Windows.Forms.Label label1;
    }
}
