namespace SalesManagement.Forms
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.DGCategory = new System.Windows.Forms.DataGridView();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCategory
            // 
            this.DGCategory.AllowUserToAddRows = false;
            this.DGCategory.AllowUserToDeleteRows = false;
            this.DGCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGCategory.BackgroundColor = System.Drawing.Color.White;
            this.DGCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGCategory.Location = new System.Drawing.Point(0, 99);
            this.DGCategory.Margin = new System.Windows.Forms.Padding(4);
            this.DGCategory.Name = "DGCategory";
            this.DGCategory.ReadOnly = true;
            this.DGCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCategory.Size = new System.Drawing.Size(363, 269);
            this.DGCategory.TabIndex = 0;
            this.DGCategory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DGView_DataBindingComplete);
            this.DGCategory.SelectionChanged += new System.EventHandler(this.DGView_SelectionChanged);
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(142, 13);
            this.TxtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(208, 25);
            this.TxtCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Category Name :";
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = global::SalesManagement.Properties.Resources.icons8_delete_bin_32;
            this.BtnDelete.Location = new System.Drawing.Point(245, 45);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(105, 47);
            this.BtnDelete.TabIndex = 12;
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
            this.BtnUpdate.Location = new System.Drawing.Point(126, 45);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(113, 47);
            this.BtnUpdate.TabIndex = 11;
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
            this.BtnAdd.Location = new System.Drawing.Point(15, 45);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(105, 47);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = " ADD";
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAddCategory_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 368);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCategory);
            this.Controls.Add(this.DGCategory);
            this.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategory_FormClosed);
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCategory;
        private System.Windows.Forms.TextBox TxtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
    }
}