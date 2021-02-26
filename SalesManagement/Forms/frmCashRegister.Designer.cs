namespace SalesManagement.Forms
{
    partial class frmCashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashRegister));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.lblNET = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnVoid = new System.Windows.Forms.Button();
            this.BtnCheckOut = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlItem = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 37);
            this.panel1.TabIndex = 0;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Café Françoise", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblUsername.Location = new System.Drawing.Point(66, 9);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(66, 23);
            this.LblUsername.TabIndex = 2;
            this.LblUsername.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Café Françoise", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "HELLO, ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Café Françoise", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(779, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "PICK A CATEGORY ♥";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lblNET);
            this.panel2.Controls.Add(this.lblVAT);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lblTotalItems);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BtnVoid);
            this.panel2.Controls.Add(this.BtnCheckOut);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(911, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 535);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgItems);
            this.panel4.Location = new System.Drawing.Point(10, 165);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(322, 296);
            this.panel4.TabIndex = 12;
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgItems.BackgroundColor = System.Drawing.Color.White;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(0, 0);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItems.Size = new System.Drawing.Size(322, 296);
            this.dgItems.TabIndex = 0;
            this.dgItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgItems_DataBindingComplete);
            this.dgItems.SelectionChanged += new System.EventHandler(this.dgItems_SelectionChanged);
            // 
            // lblNET
            // 
            this.lblNET.AutoSize = true;
            this.lblNET.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNET.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblNET.Location = new System.Drawing.Point(244, 82);
            this.lblNET.Name = "lblNET";
            this.lblNET.Size = new System.Drawing.Size(15, 20);
            this.lblNET.TabIndex = 10;
            this.lblNET.Text = "0";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblVAT.Location = new System.Drawing.Point(245, 51);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(15, 20);
            this.lblVAT.TabIndex = 9;
            this.lblVAT.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(245, 122);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(15, 20);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "0";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalItems.Location = new System.Drawing.Point(245, 17);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(15, 20);
            this.lblTotalItems.TabIndex = 7;
            this.lblTotalItems.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(67, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "NET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(68, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "VAT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(27, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOTAL PRICE ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Café Françoise", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(27, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL ITEMS ";
            // 
            // BtnVoid
            // 
            this.BtnVoid.Font = new System.Drawing.Font("Café Françoise", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoid.Location = new System.Drawing.Point(108, 467);
            this.BtnVoid.Name = "BtnVoid";
            this.BtnVoid.Size = new System.Drawing.Size(109, 56);
            this.BtnVoid.TabIndex = 2;
            this.BtnVoid.Text = "VOID";
            this.BtnVoid.UseVisualStyleBackColor = true;
            this.BtnVoid.Click += new System.EventHandler(this.BtnVoid_Click);
            // 
            // BtnCheckOut
            // 
            this.BtnCheckOut.Font = new System.Drawing.Font("Café Françoise", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOut.Location = new System.Drawing.Point(223, 467);
            this.BtnCheckOut.Name = "BtnCheckOut";
            this.BtnCheckOut.Size = new System.Drawing.Size(109, 56);
            this.BtnCheckOut.TabIndex = 1;
            this.BtnCheckOut.Text = "CHECKOUT";
            this.BtnCheckOut.UseVisualStyleBackColor = true;
            this.BtnCheckOut.Click += new System.EventHandler(this.BtnCheckOut_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.OrangeRed;
            this.label12.Location = new System.Drawing.Point(7, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(332, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "♥______________________________________♥";
            // 
            // pnlCategory
            // 
            this.pnlCategory.AutoScroll = true;
            this.pnlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            this.pnlCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCategory.Location = new System.Drawing.Point(0, 37);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(911, 105);
            this.pnlCategory.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 37);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Café Françoise", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(764, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "PICK AN ORDER ITEM ♥";
            // 
            // pnlItem
            // 
            this.pnlItem.AutoScroll = true;
            this.pnlItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(194)))));
            this.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItem.Location = new System.Drawing.Point(0, 175);
            this.pnlItem.Name = "pnlItem";
            this.pnlItem.Size = new System.Drawing.Size(911, 360);
            this.pnlItem.TabIndex = 4;
            // 
            // frmCashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 535);
            this.Controls.Add(this.pnlItem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCashRegister_FormClosed);
            this.Load += new System.EventHandler(this.frmCashRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Panel pnlItem;
        private System.Windows.Forms.Button BtnVoid;
        private System.Windows.Forms.Button BtnCheckOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNET;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgItems;
    }
}