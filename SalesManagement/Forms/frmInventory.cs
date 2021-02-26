using SalesManagement.DTO;
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
    public partial class frmInventory : Form
    {
        private List<Category> _Categories;
        private List<Supplier> _Suppliers;
        private List<ProductDTO> _Products;
        private int _ProductId = 0;
        private string _Username;

        public frmInventory(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void GetCategories()
        {
            Cafe cafe = new Cafe();
            _Categories = new List<Category>();
            _Categories = cafe.GetAllCategory();

            foreach (var category in _Categories)
                CmbCategory.Items.Add(category.CategoryName);
        }

        private void GetSuppliers()
        {
            Cafe cafe = new Cafe();
            _Suppliers = new List<Supplier>();
            _Suppliers = cafe.GetSuppliers();

            foreach (var supplier in _Suppliers)
                CmbSupplier.Items.Add(supplier.CompanyName);
        }

        private void GetProducts()
        {
            Cafe cafe = new Cafe();
            _Products = new List<ProductDTO>();
            _Products = cafe.GetProducts();
        }

        private void RefreshData()
        {
            GetProducts();
            DGStocks.DataSource = _Products;
            DGStocks.Refresh();
            BtnClear.PerformClick();
        }

        private bool HasEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtItemName.Text) || string.IsNullOrEmpty(TxtPrice.Text)
                || string.IsNullOrEmpty(TxtStocks.Text) || string.IsNullOrEmpty(CmbCategory.Text) || string.IsNullOrEmpty(CmbSupplier.Text))
                return true;
            else return false;
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetSuppliers();
            RefreshData();
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtDescription.Clear();
            TxtItemName.Clear();
            TxtPrice.Clear();
            TxtStocks.Clear();
            CmbCategory.Text = string.Empty;
            CmbSupplier.Text = string.Empty;
            _ProductId = 0; 
        }

        private void BtnNewStock_Click(object sender, EventArgs e)
        {
            if (HasEmptyFields()) MessageBox.Show("Please fill up the fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Cafe cafe = new Cafe();
                Product product = new Product()
                {
                    CategoryId = _Categories.Find(x => x.CategoryName == CmbCategory.Text).CategoryId,
                    Description = TxtDescription.Text,
                    ProductName = TxtItemName.Text,
                    ProductPrice = Convert.ToDecimal(TxtPrice.Text),
                    Quantity = Convert.ToInt32(TxtStocks.Text),
                    SupplierId = _Suppliers.Find(x => x.CompanyName == CmbSupplier.Text).SupplierId
                };

                string message = cafe.AddProduct(product);

                if (message.Contains("Pass"))
                {
                    MessageBox.Show("New product added!", "NEW PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnClear.PerformClick();
                }
                else
                    MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshData();
        }

        private void DGStocks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DGStocks.Rows.Count > 0)
            {
                DGStocks.Columns[0].Visible = false;
                DGStocks.RowHeadersVisible = false;
                //DGStocks.CurrentRow.Selected = false;
                BtnClear.PerformClick();
            }
        }

        private void DGStocks_SelectionChanged(object sender, EventArgs e)
        {
            if (DGStocks.Rows.Count > 0)
            {
                _ProductId = Convert.ToInt32(DGStocks.CurrentRow.Cells[0].Value);
                TxtItemName.Text = DGStocks.CurrentRow.Cells[1].Value.ToString();
                CmbCategory.Text = DGStocks.CurrentRow.Cells[2].Value.ToString();
                CmbSupplier.Text = DGStocks.CurrentRow.Cells[3].Value.ToString();
                TxtPrice.Text = DGStocks.CurrentRow.Cells[4].Value.ToString();
                TxtDescription.Text = DGStocks.CurrentRow.Cells[5].Value.ToString();
                TxtStocks.Text = DGStocks.CurrentRow.Cells[6].Value.ToString();
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_ProductId > 0)
            {
                if (HasEmptyFields()) MessageBox.Show("Please fill up the fields!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    var selectedProduct = _Products.Find(x => x.ProductId == _ProductId);

                    if (selectedProduct != null)
                    {
                        Cafe cafe = new Cafe();
                        Product product = new Product()
                        {
                            CategoryId = _Categories.Find(x => x.CategoryName == CmbCategory.Text).CategoryId,
                            Description = TxtDescription.Text,
                            ProductName = TxtItemName.Text,
                            ProductPrice = Convert.ToDecimal(TxtPrice.Text),
                            Quantity = Convert.ToInt32(TxtStocks.Text),
                            SupplierId = _Suppliers.Find(x => x.CompanyName == CmbSupplier.Text).SupplierId,
                            ProductId = _ProductId
                        };
                        string message = cafe.UpdateProduct(product);
                        if (message.Contains("Pass"))
                            MessageBox.Show("Product updated successfully!", "UPDATED PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("There was an error selecting a product. Please select again.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_ProductId > 0)
            {
                var result = MessageBox.Show("Are yousure you want to delete this product?", "DELETE PRODUCT", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var selectedProduct = _Products.Find(x => x.ProductId == _ProductId);

                    if (selectedProduct != null)
                    {
                        Cafe cafe = new Cafe();

                        string message = cafe.DeleteProduct(_ProductId);
                        if (message.Contains("Pass"))
                            MessageBox.Show("Product deleted successfully!", "DELETED PRODUCT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("There was an error selecting a product. Please select again.", "ERROR",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.TextLength <= 0) RefreshData();
            else
            {
                DGStocks.DataSource = _Products.Where(x => x.Product.ToLower().Contains(TxtSearch.Text) || x.Description.ToLower().Contains(TxtSearch.Text) ||
                x.Category.ToLower().Contains(TxtSearch.Text) || x.Supplier.ToLower().Contains(TxtSearch.Text)).ToList();
                DGStocks.Refresh();
            }
        }

        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            Hide();
            form.Show();
        }
    }
}
