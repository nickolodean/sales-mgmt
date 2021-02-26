namespace SalesManagement.Forms
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DTDateTo = new System.Windows.Forms.DateTimePicker();
            this.DTDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DGTransaction = new System.Windows.Forms.DataGridView();
            this.BtnPrintReport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotalTransactions = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(80, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(255, 25);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DTDateTo
            // 
            this.DTDateTo.Location = new System.Drawing.Point(419, 61);
            this.DTDateTo.Name = "DTDateTo";
            this.DTDateTo.Size = new System.Drawing.Size(233, 25);
            this.DTDateTo.TabIndex = 2;
            this.DTDateTo.ValueChanged += new System.EventHandler(this.DTDateTo_ValueChanged);
            // 
            // DTDateFrom
            // 
            this.DTDateFrom.Location = new System.Drawing.Point(102, 61);
            this.DTDateFrom.Name = "DTDateFrom";
            this.DTDateFrom.Size = new System.Drawing.Size(233, 25);
            this.DTDateFrom.TabIndex = 3;
            this.DTDateFrom.ValueChanged += new System.EventHandler(this.DTDateFrom_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date To:";
            // 
            // DGTransaction
            // 
            this.DGTransaction.AllowUserToAddRows = false;
            this.DGTransaction.AllowUserToDeleteRows = false;
            this.DGTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGTransaction.BackgroundColor = System.Drawing.Color.White;
            this.DGTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTransaction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGTransaction.Location = new System.Drawing.Point(0, 92);
            this.DGTransaction.Name = "DGTransaction";
            this.DGTransaction.ReadOnly = true;
            this.DGTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTransaction.Size = new System.Drawing.Size(965, 396);
            this.DGTransaction.TabIndex = 6;
            // 
            // BtnPrintReport
            // 
            this.BtnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.BtnPrintReport.FlatAppearance.BorderSize = 0;
            this.BtnPrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrintReport.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintReport.Image = global::SalesManagement.Properties.Resources.icons8_print_20;
            this.BtnPrintReport.Location = new System.Drawing.Point(801, 12);
            this.BtnPrintReport.Name = "BtnPrintReport";
            this.BtnPrintReport.Size = new System.Drawing.Size(152, 74);
            this.BtnPrintReport.TabIndex = 7;
            this.BtnPrintReport.Text = "PRINT REPORT";
            this.BtnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrintReport.UseVisualStyleBackColor = false;
            this.BtnPrintReport.Click += new System.EventHandler(this.BtnPrintReport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Transactions :";
            // 
            // LblTotalTransactions
            // 
            this.LblTotalTransactions.AutoSize = true;
            this.LblTotalTransactions.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalTransactions.Location = new System.Drawing.Point(599, 19);
            this.LblTotalTransactions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalTransactions.Name = "LblTotalTransactions";
            this.LblTotalTransactions.Size = new System.Drawing.Size(16, 18);
            this.LblTotalTransactions.TabIndex = 9;
            this.LblTotalTransactions.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(764, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "_________________________________________________________________________________" +
    "___________________________";
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 488);
            this.Controls.Add(this.LblTotalTransactions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnPrintReport);
            this.Controls.Add(this.DGTransaction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTDateFrom);
            this.Controls.Add(this.DTDateTo);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTransaction_FormClosed);
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DateTimePicker DTDateTo;
        private System.Windows.Forms.DateTimePicker DTDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGTransaction;
        private System.Windows.Forms.Button BtnPrintReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotalTransactions;
        private System.Windows.Forms.Label label5;
    }
}