namespace Washing_App
{
    partial class NewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrders));
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvPriceDetiles = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txSearch = new System.Windows.Forms.TextBox();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btRemoveAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckCard = new System.Windows.Forms.RadioButton();
            this.txCustomerPaid = new System.Windows.Forms.TextBox();
            this.ckCash = new System.Windows.Forms.RadioButton();
            this.txNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbLate = new System.Windows.Forms.RadioButton();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btRemoveLastOne = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceDetiles)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.Location = new System.Drawing.Point(17, 296);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(543, 440);
            this.flpItems.TabIndex = 0;
            // 
            // dgvPriceDetiles
            // 
            this.dgvPriceDetiles.AllowUserToAddRows = false;
            this.dgvPriceDetiles.AllowUserToDeleteRows = false;
            this.dgvPriceDetiles.AllowUserToOrderColumns = true;
            this.dgvPriceDetiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceDetiles.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPriceDetiles.Location = new System.Drawing.Point(649, 276);
            this.dgvPriceDetiles.Name = "dgvPriceDetiles";
            this.dgvPriceDetiles.ReadOnly = true;
            this.dgvPriceDetiles.RowHeadersVisible = false;
            this.dgvPriceDetiles.RowHeadersWidth = 51;
            this.dgvPriceDetiles.RowTemplate.Height = 26;
            this.dgvPriceDetiles.Size = new System.Drawing.Size(446, 374);
            this.dgvPriceDetiles.TabIndex = 1;
            this.dgvPriceDetiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPriceDetiles_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 30);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Washing_App.Properties.Resources.Delete_32;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txSearch
            // 
            this.txSearch.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSearch.ForeColor = System.Drawing.Color.Gray;
            this.txSearch.Location = new System.Drawing.Point(17, 262);
            this.txSearch.Multiline = true;
            this.txSearch.Name = "txSearch";
            this.txSearch.Size = new System.Drawing.Size(543, 28);
            this.txSearch.TabIndex = 2;
            this.txSearch.TextChanged += new System.EventHandler(this.txSearch_TextChanged);
            // 
            // btCheckOut
            // 
            this.btCheckOut.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckOut.Location = new System.Drawing.Point(813, 729);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(138, 38);
            this.btCheckOut.TabIndex = 39;
            this.btCheckOut.Text = "Cash out";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(741, 707);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(56, 70);
            this.lbTotal.TabIndex = 40;
            this.lbTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 685);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "total";
            // 
            // btRemoveAll
            // 
            this.btRemoveAll.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveAll.Location = new System.Drawing.Point(957, 685);
            this.btRemoveAll.Name = "btRemoveAll";
            this.btRemoveAll.Size = new System.Drawing.Size(138, 38);
            this.btRemoveAll.TabIndex = 42;
            this.btRemoveAll.Text = "Romve All";
            this.btRemoveAll.UseVisualStyleBackColor = true;
            this.btRemoveAll.Click += new System.EventHandler(this.btRemoveAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txPhone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txFirstName);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 132);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone :";
            // 
            // txPhone
            // 
            this.txPhone.Location = new System.Drawing.Point(118, 85);
            this.txPhone.Name = "txPhone";
            this.txPhone.Size = new System.Drawing.Size(197, 24);
            this.txPhone.TabIndex = 13;
            this.txPhone.Text = "0";
            this.txPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txOnlyDigit_KeyPress);
            this.txPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name :";
            // 
            // txLastName
            // 
            this.txLastName.Location = new System.Drawing.Point(429, 40);
            this.txLastName.Name = "txLastName";
            this.txLastName.Size = new System.Drawing.Size(143, 24);
            this.txLastName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name :";
            // 
            // txFirstName
            // 
            this.txFirstName.Location = new System.Drawing.Point(118, 41);
            this.txFirstName.Name = "txFirstName";
            this.txFirstName.Size = new System.Drawing.Size(197, 24);
            this.txFirstName.TabIndex = 9;
            this.txFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTextBox);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ckCard);
            this.groupBox3.Controls.Add(this.txCustomerPaid);
            this.groupBox3.Controls.Add(this.ckCash);
            this.groupBox3.Controls.Add(this.txNote);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(631, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 258);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 16;
            this.label11.Text = "Paid :";
            // 
            // ckCard
            // 
            this.ckCard.AutoSize = true;
            this.ckCard.Location = new System.Drawing.Point(207, 33);
            this.ckCard.Name = "ckCard";
            this.ckCard.Size = new System.Drawing.Size(58, 21);
            this.ckCard.TabIndex = 24;
            this.ckCard.Text = "Card";
            this.ckCard.UseVisualStyleBackColor = true;
            // 
            // txCustomerPaid
            // 
            this.txCustomerPaid.Location = new System.Drawing.Point(108, 70);
            this.txCustomerPaid.Name = "txCustomerPaid";
            this.txCustomerPaid.Size = new System.Drawing.Size(143, 24);
            this.txCustomerPaid.TabIndex = 15;
            this.txCustomerPaid.Text = "0";
            this.txCustomerPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txOnlyDigit_KeyPress);
            this.txCustomerPaid.Validating += new System.ComponentModel.CancelEventHandler(this.txCustomerPaid_Validating);
            // 
            // ckCash
            // 
            this.ckCash.AutoSize = true;
            this.ckCash.Checked = true;
            this.ckCash.Location = new System.Drawing.Point(107, 33);
            this.ckCash.Name = "ckCash";
            this.ckCash.Size = new System.Drawing.Size(59, 21);
            this.ckCash.TabIndex = 23;
            this.ckCash.TabStop = true;
            this.ckCash.Text = "Cash";
            this.ckCash.UseVisualStyleBackColor = true;
            // 
            // txNote
            // 
            this.txNote.Location = new System.Drawing.Point(18, 138);
            this.txNote.Multiline = true;
            this.txNote.Name = "txNote";
            this.txNote.Size = new System.Drawing.Size(446, 106);
            this.txNote.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Note :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Payment :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbLate);
            this.groupBox4.Controls.Add(this.rbFast);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(22, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(543, 79);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Washing Type / Time ";
            // 
            // rbLate
            // 
            this.rbLate.AutoSize = true;
            this.rbLate.Location = new System.Drawing.Point(257, 37);
            this.rbLate.Name = "rbLate";
            this.rbLate.Size = new System.Drawing.Size(72, 21);
            this.rbLate.TabIndex = 30;
            this.rbLate.Text = "Normal";
            this.rbLate.UseVisualStyleBackColor = true;
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Checked = true;
            this.rbFast.Location = new System.Drawing.Point(157, 37);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(54, 21);
            this.rbFast.TabIndex = 29;
            this.rbFast.TabStop = true;
            this.rbFast.Text = "Fast";
            this.rbFast.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Washing Time :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(690, 707);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 70);
            this.label8.TabIndex = 45;
            this.label8.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Search :";
            // 
            // btPrint
            // 
            this.btPrint.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.Location = new System.Drawing.Point(957, 729);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(138, 38);
            this.btPrint.TabIndex = 46;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btRemoveLastOne
            // 
            this.btRemoveLastOne.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemoveLastOne.Location = new System.Drawing.Point(813, 685);
            this.btRemoveLastOne.Name = "btRemoveLastOne";
            this.btRemoveLastOne.Size = new System.Drawing.Size(138, 38);
            this.btRemoveLastOne.TabIndex = 47;
            this.btRemoveLastOne.Text = "Romve";
            this.btRemoveLastOne.UseVisualStyleBackColor = true;
            this.btRemoveLastOne.Click += new System.EventHandler(this.btRemoveLastOne_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(649, 657);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 23);
            this.label5.TabIndex = 48;
            this.label5.Text = "* Right Click or press DEL to delete items ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // NewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1127, 836);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btRemoveLastOne);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRemoveAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.txSearch);
            this.Controls.Add(this.dgvPriceDetiles);
            this.Controls.Add(this.flpItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewOrders";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.frmNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceDetiles)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.DataGridView dgvPriceDetiles;
        private System.Windows.Forms.TextBox txSearch;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRemoveAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ckCard;
        private System.Windows.Forms.RadioButton ckCash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbLate;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txCustomerPaid;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btRemoveLastOne;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}