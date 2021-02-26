namespace SalesManagement.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.BtnSupplier = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnInventory = new System.Windows.Forms.Button();
            this.BtnCashRegister = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnTransaction = new System.Windows.Forms.Button();
            this.BtnUserSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSupplier
            // 
            this.BtnSupplier.BackColor = System.Drawing.Color.Transparent;
            this.BtnSupplier.FlatAppearance.BorderSize = 0;
            this.BtnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupplier.Image = global::SalesManagement.Properties.Resources.icons8_supplier_96;
            this.BtnSupplier.Location = new System.Drawing.Point(584, 23);
            this.BtnSupplier.Name = "BtnSupplier";
            this.BtnSupplier.Size = new System.Drawing.Size(135, 126);
            this.BtnSupplier.TabIndex = 18;
            this.BtnSupplier.Text = "SUPPLIER";
            this.BtnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSupplier.UseVisualStyleBackColor = false;
            this.BtnSupplier.Click += new System.EventHandler(this.BtnSupplier_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.Image = global::SalesManagement.Properties.Resources.icons8_business_report_96;
            this.BtnDashboard.Location = new System.Drawing.Point(490, 196);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(135, 126);
            this.BtnDashboard.TabIndex = 17;
            this.BtnDashboard.Text = " DASHBOARD";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventory.FlatAppearance.BorderSize = 0;
            this.BtnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventory.Image = global::SalesManagement.Properties.Resources.icons8_warehouse_100;
            this.BtnInventory.Location = new System.Drawing.Point(305, 196);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(135, 126);
            this.BtnInventory.TabIndex = 16;
            this.BtnInventory.Text = " INVENTORY";
            this.BtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnInventory.UseVisualStyleBackColor = false;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnCashRegister
            // 
            this.BtnCashRegister.BackColor = System.Drawing.Color.Transparent;
            this.BtnCashRegister.FlatAppearance.BorderSize = 0;
            this.BtnCashRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCashRegister.Image = global::SalesManagement.Properties.Resources.icons8_cash_register_100;
            this.BtnCashRegister.Location = new System.Drawing.Point(122, 196);
            this.BtnCashRegister.Name = "BtnCashRegister";
            this.BtnCashRegister.Size = new System.Drawing.Size(135, 126);
            this.BtnCashRegister.TabIndex = 15;
            this.BtnCashRegister.Text = " CASH REGISTER";
            this.BtnCashRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCashRegister.UseVisualStyleBackColor = false;
            this.BtnCashRegister.Click += new System.EventHandler(this.BtnCashRegister_Click);
            // 
            // BtnCategory
            // 
            this.BtnCategory.BackColor = System.Drawing.Color.Transparent;
            this.BtnCategory.FlatAppearance.BorderSize = 0;
            this.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.Image = global::SalesManagement.Properties.Resources.icons8_elective_100;
            this.BtnCategory.Location = new System.Drawing.Point(412, 23);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(135, 126);
            this.BtnCategory.TabIndex = 14;
            this.BtnCategory.Text = "  CATEGORY";
            this.BtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCategory.UseVisualStyleBackColor = false;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnTransaction
            // 
            this.BtnTransaction.BackColor = System.Drawing.Color.Transparent;
            this.BtnTransaction.FlatAppearance.BorderSize = 0;
            this.BtnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTransaction.Image = global::SalesManagement.Properties.Resources.icons8_transaction_list_100;
            this.BtnTransaction.Location = new System.Drawing.Point(219, 23);
            this.BtnTransaction.Name = "BtnTransaction";
            this.BtnTransaction.Size = new System.Drawing.Size(135, 126);
            this.BtnTransaction.TabIndex = 13;
            this.BtnTransaction.Text = "TRANSACTIONS";
            this.BtnTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTransaction.UseVisualStyleBackColor = false;
            this.BtnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // BtnUserSetting
            // 
            this.BtnUserSetting.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserSetting.FlatAppearance.BorderSize = 0;
            this.BtnUserSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserSetting.Image = global::SalesManagement.Properties.Resources.icons8_user_settings_100;
            this.BtnUserSetting.Location = new System.Drawing.Point(40, 23);
            this.BtnUserSetting.Name = "BtnUserSetting";
            this.BtnUserSetting.Size = new System.Drawing.Size(135, 126);
            this.BtnUserSetting.TabIndex = 12;
            this.BtnUserSetting.Text = "USER SETTING";
            this.BtnUserSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUserSetting.UseVisualStyleBackColor = false;
            this.BtnUserSetting.Click += new System.EventHandler(this.BtnUserSetting_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 366);
            this.Controls.Add(this.BtnSupplier);
            this.Controls.Add(this.BtnDashboard);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnCashRegister);
            this.Controls.Add(this.BtnCategory);
            this.Controls.Add(this.BtnTransaction);
            this.Controls.Add(this.BtnUserSetting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe and Snack Bar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnUserSetting;
        private System.Windows.Forms.Button BtnTransaction;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnCashRegister;
        private System.Windows.Forms.Button BtnInventory;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnSupplier;
    }
}