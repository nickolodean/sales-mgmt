namespace SalesManagement.Forms
{
    partial class frmInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.label7 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtStocks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtItemName = new System.Windows.Forms.TextBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNewStock = new System.Windows.Forms.Button();
            this.LblItemCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DGStocks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSupplier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Category :";
            // 
            // CmbCategory
            // 
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Location = new System.Drawing.Point(112, 206);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(292, 26);
            this.CmbCategory.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stocks :";
            // 
            // TxtStocks
            // 
            this.TxtStocks.Location = new System.Drawing.Point(112, 310);
            this.TxtStocks.Name = "TxtStocks";
            this.TxtStocks.Size = new System.Drawing.Size(292, 25);
            this.TxtStocks.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Item Price :";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(112, 270);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(292, 25);
            this.TxtPrice.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Description :";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(111, 114);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(292, 77);
            this.TxtDescription.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name :";
            // 
            // TxtItemName
            // 
            this.TxtItemName.Location = new System.Drawing.Point(111, 73);
            this.TxtItemName.Name = "TxtItemName";
            this.TxtItemName.Size = new System.Drawing.Size(293, 25);
            this.TxtItemName.TabIndex = 23;
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.BtnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("BtnClear.Image")));
            this.BtnClear.Location = new System.Drawing.Point(199, 341);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(204, 42);
            this.BtnClear.TabIndex = 35;
            this.BtnClear.Text = "CLEAR INPUTS";
            this.BtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.Location = new System.Drawing.Point(12, 391);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(179, 51);
            this.BtnEdit.TabIndex = 34;
            this.BtnEdit.Text = "UPDATE";
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(199, 389);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(205, 51);
            this.BtnDelete.TabIndex = 33;
            this.BtnDelete.Text = " DELETE";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNewStock
            // 
            this.BtnNewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(226)))), ((int)(((byte)(176)))));
            this.BtnNewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNewStock.FlatAppearance.BorderSize = 0;
            this.BtnNewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewStock.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewStock.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewStock.Image")));
            this.BtnNewStock.Location = new System.Drawing.Point(12, 341);
            this.BtnNewStock.Name = "BtnNewStock";
            this.BtnNewStock.Size = new System.Drawing.Size(179, 44);
            this.BtnNewStock.TabIndex = 36;
            this.BtnNewStock.Text = "NEW STOCK";
            this.BtnNewStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnNewStock.UseVisualStyleBackColor = false;
            this.BtnNewStock.Click += new System.EventHandler(this.BtnNewStock_Click);
            // 
            // LblItemCount
            // 
            this.LblItemCount.AutoSize = true;
            this.LblItemCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblItemCount.Location = new System.Drawing.Point(290, 40);
            this.LblItemCount.Name = "LblItemCount";
            this.LblItemCount.Size = new System.Drawing.Size(83, 20);
            this.LblItemCount.TabIndex = 38;
            this.LblItemCount.Text = "itemCount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total Item :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Search :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(111, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(292, 25);
            this.TxtSearch.TabIndex = 39;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DGStocks
            // 
            this.DGStocks.AllowUserToAddRows = false;
            this.DGStocks.AllowUserToDeleteRows = false;
            this.DGStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGStocks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGStocks.BackgroundColor = System.Drawing.Color.White;
            this.DGStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGStocks.Location = new System.Drawing.Point(420, 12);
            this.DGStocks.Name = "DGStocks";
            this.DGStocks.ReadOnly = true;
            this.DGStocks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGStocks.Size = new System.Drawing.Size(802, 430);
            this.DGStocks.TabIndex = 41;
            this.DGStocks.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGStocks_DataBindingComplete);
            this.DGStocks.SelectionChanged += new System.EventHandler(this.DGStocks_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Supplier :";
            // 
            // CmbSupplier
            // 
            this.CmbSupplier.FormattingEnabled = true;
            this.CmbSupplier.Location = new System.Drawing.Point(112, 238);
            this.CmbSupplier.Name = "CmbSupplier";
            this.CmbSupplier.Size = new System.Drawing.Size(292, 26);
            this.CmbSupplier.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(405, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "__________________________________________________________________";
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbSupplier);
            this.Controls.Add(this.DGStocks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.LblItemCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnNewStock);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtStocks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtItemName);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventory_FormClosed);
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtStocks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtItemName;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnNewStock;
        private System.Windows.Forms.Label LblItemCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DGStocks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSupplier;
        private System.Windows.Forms.Label label9;
    }
}