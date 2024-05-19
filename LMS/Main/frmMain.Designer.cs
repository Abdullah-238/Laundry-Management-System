namespace Washing_App
{
    partial class frmMain
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btNewOrder = new System.Windows.Forms.Button();
            this.ucMainHeader1 = new Washing_App.Main.ucMainHeader();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Washing_App.Properties.Resources.purchase_order__2_;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(205, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 71);
            this.button3.TabIndex = 5;
            this.button3.Text = "Complete Order";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Washing_App.Properties.Resources.settings;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(446, 447);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 71);
            this.button4.TabIndex = 4;
            this.button4.Text = "Settings";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Washing_App.Properties.Resources.sign_out__1_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(639, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Log out";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btNewOrder
            // 
            this.btNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNewOrder.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewOrder.ForeColor = System.Drawing.Color.White;
            this.btNewOrder.Image = global::Washing_App.Properties.Resources.purchase_order__1_;
            this.btNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNewOrder.Location = new System.Drawing.Point(12, 447);
            this.btNewOrder.Name = "btNewOrder";
            this.btNewOrder.Size = new System.Drawing.Size(192, 71);
            this.btNewOrder.TabIndex = 1;
            this.btNewOrder.Text = "New Order";
            this.btNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNewOrder.UseVisualStyleBackColor = false;
            this.btNewOrder.Click += new System.EventHandler(this.button2_Click);
            // 
            // ucMainHeader1
            // 
            this.ucMainHeader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ucMainHeader1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucMainHeader1.Location = new System.Drawing.Point(0, 501);
            this.ucMainHeader1.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.ucMainHeader1.Name = "ucMainHeader1";
            this.ucMainHeader1.Size = new System.Drawing.Size(1070, 29);
            this.ucMainHeader1.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 530);
            this.Controls.Add(this.ucMainHeader1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btNewOrder);
            this.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "frmMain";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btNewOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Main.ucMainHeader ucMainHeader1;
    }
}