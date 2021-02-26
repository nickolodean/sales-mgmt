using SalesManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement.Forms
{
    public partial class SupplierForm : Form
    {
        private int _SupplierId = 0;
        private List<Supplier> _Suppliers;
        private string _Username;

        public SupplierForm(string username)
        {
            InitializeComponent();
            _Username = username;

        }

        private void ClearFields()
        {
            TxtAddress.Clear();
            TxtCompanyName.Clear();
            TxtContactNo.Clear();
            TxtContactPerson.Clear();
            TxtLandline.Clear();
        }

        private void RefreshData()
        {
            Cafe cafe = new Cafe();
            _Suppliers = cafe.GetSuppliers();
            DGSupplier.DataSource = _Suppliers.Select(x => new
            {
                x.SupplierId,
                x.CompanyName,
                x.Address,
                x.ContactNumber,
                x.Landline,
                x.ContactPerson
            }).ToList();
            DGSupplier.Refresh();
            LblCount.Text = _Suppliers.Count().ToString();
            _SupplierId = 0;
            BtnAdd.Enabled = true;
            BtnDelete.Enabled = false;
            BtnUpdate.Enabled = false;
        }

        private bool HasImportantEmptyField()
        {
            if (string.IsNullOrEmpty(TxtCompanyName.Text) || string.IsNullOrEmpty(TxtContactPerson.Text)
                || string.IsNullOrEmpty(TxtAddress.Text))
                return true;
            else return false;

        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void DGSupplier_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DGSupplier.Rows.Count > 0) DGSupplier.CurrentRow.Selected = false;
            ClearFields();
            DGSupplier.RowHeadersVisible = false;
            DGSupplier.Columns[0].Visible = false;
        }

        private void DGSupplier_SelectionChanged(object sender, EventArgs e)
        {
            _SupplierId = Convert.ToInt32(DGSupplier.CurrentRow.Cells[0].Value);
            TxtCompanyName.Text = DGSupplier.CurrentRow.Cells[1].Value.ToString();
            TxtAddress.Text = DGSupplier.CurrentRow.Cells[2].Value.ToString();
            TxtContactNo.Text = DGSupplier.CurrentRow.Cells[3].Value.ToString();
            TxtLandline.Text = DGSupplier.CurrentRow.Cells[4].Value.ToString();
            TxtContactPerson.Text = DGSupplier.CurrentRow.Cells[5].Value.ToString();
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = true;
            BtnUpdate.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!HasImportantEmptyField())
            {
                Cafe cafe = new Cafe();
                Supplier supplier = new Supplier()
                {
                    Address = TxtAddress.Text.Trim(),
                    CompanyName = TxtCompanyName.Text.Trim(),
                    ContactNumber = TxtContactNo.Text.Trim(),
                    ContactPerson = TxtContactPerson.Text.Trim(),
                    Landline = TxtLandline.Text.Trim()
                };
                string message = cafe.AddSupplier(supplier);
                if (message.Contains("Pass"))
                    MessageBox.Show("Successfull Added!", "NEW SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                RefreshData();
                ClearFields();
            }
            else MessageBox.Show("Please fill up the required fields!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_SupplierId > 0)
            {
                Cafe cafe = new Cafe();
                Supplier supplier = new Supplier()
                {
                    SupplierId = _SupplierId,
                    Address = TxtAddress.Text.Trim(),
                    CompanyName = TxtCompanyName.Text.Trim(),
                    ContactNumber = TxtContactNo.Text.Trim(),
                    ContactPerson = TxtContactPerson.Text.Trim(),
                    Landline = TxtLandline.Text.Trim()
                };
                string message = cafe.UpdateSupplier(supplier);
                if (message.Contains("Pass"))
                    MessageBox.Show("Successfull Updated!", "NEW SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SupplierId = 0;
                RefreshData();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this supplier?", "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_SupplierId > 0)
            {
                Cafe cafe = new Cafe();
                string message = cafe.DeleteSupplier(_SupplierId);
                if (message.Contains("Pass")) 
                    MessageBox.Show("Successfull Deleted!", "DELETED SUPPLIER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _SupplierId = 0;
                RefreshData();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.TextLength <= 0) RefreshData();
            else
            {
                var supplierSearch = _Suppliers.Where(x => x.CompanyName.ToLower().Contains(TxtSearch.Text.ToLower()) 
                || x.ContactPerson.ToLower().Contains(TxtSearch.Text.ToLower()) || x.Address.ToLower().Contains(TxtSearch.Text.ToLower()))
                    .Select(x => new
                {
                    x.SupplierId,
                    x.CompanyName,
                    x.Address,
                    x.ContactNumber,
                    x.Landline,
                    x.ContactPerson
                }).ToList();

                DGSupplier.DataSource = supplierSearch;
                DGSupplier.Refresh();

                LblCount.Text = supplierSearch.Count().ToString();
            }
        }

        private void SupplierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            Hide();
            form.Show();
        }
    }
}
