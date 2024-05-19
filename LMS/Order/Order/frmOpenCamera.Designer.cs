namespace Washing_App.Order.Order
{
    partial class frmOpenCamera
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txOrderID = new System.Windows.Forms.TextBox();
            this.btConfrim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 596);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txOrderID
            // 
            this.txOrderID.Location = new System.Drawing.Point(357, 657);
            this.txOrderID.Multiline = true;
            this.txOrderID.Name = "txOrderID";
            this.txOrderID.ReadOnly = true;
            this.txOrderID.Size = new System.Drawing.Size(100, 37);
            this.txOrderID.TabIndex = 1;
            // 
            // btConfrim
            // 
            this.btConfrim.Location = new System.Drawing.Point(337, 706);
            this.btConfrim.Name = "btConfrim";
            this.btConfrim.Size = new System.Drawing.Size(141, 37);
            this.btConfrim.TabIndex = 2;
            this.btConfrim.Text = "Confrim";
            this.btConfrim.UseVisualStyleBackColor = true;
            this.btConfrim.Click += new System.EventHandler(this.btConfrim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID :";
            // 
            // frmOpenCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConfrim);
            this.Controls.Add(this.txOrderID);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmOpenCamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOpenCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOpenCamera_FormClosing);
            this.Load += new System.EventHandler(this.frmOpenCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txOrderID;
        private System.Windows.Forms.Button btConfrim;
        private System.Windows.Forms.Label label1;
    }
}