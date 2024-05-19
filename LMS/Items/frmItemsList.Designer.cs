namespace Washing_App
{
    partial class frmItemsList
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.lbNumberOfUsers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAddNewItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(141, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.updateUserToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 94);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Image = global::Washing_App.Properties.Resources.action_items_list_add;
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.addUserToolStripMenuItem.Text = "Add item";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Image = global::Washing_App.Properties.Resources.edit_32;
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.updateUserToolStripMenuItem.Text = "Update ";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Washing_App.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txSearch
            // 
            this.txSearch.Location = new System.Drawing.Point(302, 190);
            this.txSearch.Multiline = true;
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(191, 38);
            this.txSearch.TabIndex = 31;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            this.txSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSearch_KeyPress);
            // 
            // lbNumberOfUsers
            // 
            this.lbNumberOfUsers.AutoSize = true;
            this.lbNumberOfUsers.Location = new System.Drawing.Point(102, 536);
            this.lbNumberOfUsers.Name = "lbNumberOfUsers";
            this.lbNumberOfUsers.Size = new System.Drawing.Size(24, 30);
            this.lbNumberOfUsers.TabIndex = 28;
            this.lbNumberOfUsers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Record :";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Item ID",
            "Item Name",
            "Item Price"});
            this.cbFilterBy.Location = new System.Drawing.Point(107, 190);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(174, 38);
            this.cbFilterBy.TabIndex = 26;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Filter by :";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvItems.Location = new System.Drawing.Point(11, 234);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 26;
            this.dgvItems.Size = new System.Drawing.Size(647, 292);
            this.dgvItems.TabIndex = 24;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Teal;
            this.lbTitle.Location = new System.Drawing.Point(225, 128);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(314, 50);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "Items Management";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Image = global::Washing_App.Properties.Resources.close;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.Location = new System.Drawing.Point(552, 532);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(106, 38);
            this.btCancel.TabIndex = 30;
            this.btCancel.Text = "Close";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAddNewItem
            // 
            this.btAddNewItem.Image = global::Washing_App.Properties.Resources.action_items_list_add;
            this.btAddNewItem.Location = new System.Drawing.Point(581, 181);
            this.btAddNewItem.Name = "btAddNewItem";
            this.btAddNewItem.Size = new System.Drawing.Size(77, 42);
            this.btAddNewItem.TabIndex = 29;
            this.btAddNewItem.UseVisualStyleBackColor = true;
            this.btAddNewItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Washing_App.Properties.Resources.action_items_list;
            this.pictureBox1.Location = new System.Drawing.Point(302, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 581);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAddNewItem);
            this.Controls.Add(this.lbNumberOfUsers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmItemsList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items List";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAddNewItem;
        private System.Windows.Forms.Label lbNumberOfUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lbTitle;
    }
}