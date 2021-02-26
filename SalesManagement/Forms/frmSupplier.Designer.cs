namespace SalesManagement.Forms
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtContactPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtLandline = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DGSupplier = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(144, 96);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(276, 25);
            this.TxtCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact Number:";
            // 
            // TxtContactNo
            // 
            this.TxtContactNo.Location = new System.Drawing.Point(144, 141);
            this.TxtContactNo.Name = "TxtContactNo";
            this.TxtContactNo.Size = new System.Drawing.Size(276, 25);
            this.TxtContactNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contact Person:";
            // 
            // TxtContactPerson
            // 
            this.TxtContactPerson.Location = new System.Drawing.Point(144, 189);
            this.TxtContactPerson.Name = "TxtContactPerson";
            this.TxtContactPerson.Size = new System.Drawing.Size(276, 25);
            this.TxtContactPerson.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Landline:";
            // 
            // TxtLandline
            // 
            this.TxtLandline.Location = new System.Drawing.Point(144, 234);
            this.TxtLandline.Name = "TxtLandline";
            this.TxtLandline.Size = new System.Drawing.Size(276, 25);
            this.TxtLandline.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(144, 274);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(276, 61);
            this.TxtAddress.TabIndex = 8;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::SalesManagement.Properties.Resources.icons8_delete_bin_32;
            this.BtnDelete.Location = new System.Drawing.Point(277, 355);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 47);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "DELETE";
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(134)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Image = global::SalesManagement.Properties.Resources.icons8_edit_32;
            this.BtnUpdate.Location = new System.Drawing.Point(158, 355);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(113, 47);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = " UPDATE";
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(226)))), ((int)(((byte)(176)))));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Image = global::SalesManagement.Properties.Resources.icons8_add_32;
            this.BtnAdd.Location = new System.Drawing.Point(47, 355);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 47);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = " ADD";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGSupplier
            // 
            this.DGSupplier.AllowUserToAddRows = false;
            this.DGSupplier.AllowUserToDeleteRows = false;
            this.DGSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGSupplier.BackgroundColor = System.Drawing.Color.White;
            this.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSupplier.Dock = System.Windows.Forms.DockStyle.Right;
            this.DGSupplier.Location = new System.Drawing.Point(426, 0);
            this.DGSupplier.Name = "DGSupplier";
            this.DGSupplier.ReadOnly = true;
            this.DGSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSupplier.Size = new System.Drawing.Size(560, 414);
            this.DGSupplier.TabIndex = 16;
            this.DGSupplier.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGSupplier_DataBindingComplete);
            this.DGSupplier.SelectionChanged += new System.EventHandler(this.DGSupplier_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(23, 30);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(189, 25);
            this.TxtSearch.TabIndex = 17;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Total Count:";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(341, 33);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(16, 18);
            this.LblCount.TabIndex = 20;
            this.LblCount.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(421, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "___________________________________________________________";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(986, 414);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.DGSupplier);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtLandline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtContactPerson);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtContactNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCompanyName);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SupplierForm_FormClosed);
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtContactPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtLandline;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DGSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label label9;
    }
}