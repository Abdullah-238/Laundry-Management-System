namespace Washing_App.Laundry
{
    partial class frmLaundryList
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
            this.btCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvLuandries = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btAddNewItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuandries)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::Washing_App.Properties.Resources.close;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(354, 465);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(106, 38);
            this.btCancel.TabIndex = 20;
            this.btCancel.Text = "Close";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Washing_App.Properties.Resources.washing_machine__1_;
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = global::Washing_App.Properties.Resources.edit_32;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.updateUserToolStripMenuItem.Text = "Update ";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = global::Washing_App.Properties.Resources.washing_machine;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addUserToolStripMenuItem.Text = "Add Laundry";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.updateUserToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 68);
            // 
            // dgvLuandries
            // 
            this.dgvLuandries.AllowUserToAddRows = false;
            this.dgvLuandries.AllowUserToDeleteRows = false;
            this.dgvLuandries.AllowUserToOrderColumns = true;
            this.dgvLuandries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuandries.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLuandries.Location = new System.Drawing.Point(12, 167);
            this.dgvLuandries.Name = "dgvLuandries";
            this.dgvLuandries.ReadOnly = true;
            this.dgvLuandries.RowHeadersVisible = false;
            this.dgvLuandries.RowHeadersWidth = 51;
            this.dgvLuandries.RowTemplate.Height = 26;
            this.dgvLuandries.Size = new System.Drawing.Size(448, 292);
            this.dgvLuandries.TabIndex = 14;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(168, 109);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(142, 50);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "Laundry";
            // 
            // btAddNewItem
            // 
            this.btAddNewItem.Location = new System.Drawing.Point(383, 119);
            this.btAddNewItem.Name = "btAddNewItem";
            this.btAddNewItem.Size = new System.Drawing.Size(77, 42);
            this.btAddNewItem.TabIndex = 30;
            this.btAddNewItem.Text = "Add";
            this.btAddNewItem.UseVisualStyleBackColor = true;
            this.btAddNewItem.Click += new System.EventHandler(this.btAddNewItem_Click);
            // 
            // frmLaundryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 530);
            this.Controls.Add(this.btAddNewItem);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLuandries);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLaundryList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laundry List";
            this.Load += new System.EventHandler(this.frmLaundryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuandries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvLuandries;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btAddNewItem;
    }
}