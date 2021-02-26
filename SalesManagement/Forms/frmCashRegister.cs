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
    public partial class frmCashRegister : Form
    {
        private Button _DynamicButton;
        private Button _DynamicItemButton;
        private List<Category> _Categories;
        private List<ProductDTO> _Products;
        private List<TransactionDTO> _SelectedItems = new List<TransactionDTO>();
        private TransactionDTO _SelectedItem;
        private string _Username;
        private decimal _TotalPrice;

        public frmCashRegister(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void GetCategories()
        {
            Cafe cafe = new Cafe();
            _Categories = new List<Category>();
            _Categories = cafe.GetAllCategory();
            int index = 0;
            int buttonPadding = pnlCategory.Width / _Categories.Count;
            int dynamicButtonWidth = (pnlCategory.Width - buttonPadding) / _Categories.Count;

            foreach (var category in _Categories)
            {
                if (index == 0)
                    InitializeCategoryButton(category.CategoryName, dynamicButtonWidth, 6 + 0);
                else
                    InitializeCategoryButton(category.CategoryName, dynamicButtonWidth, (dynamicButtonWidth * index) + ((6 * index) + 6));
                index++;
            }
        }

        private void GetItems(string category)
        {
            var products = _Products.Where(x => x.Category == category).ToList();

            int index = 0;
            int currentLocationY = 0;
            double buttonPadding = pnlItem.Width - (pnlItem.Width * 0.92);
            int dynamicButtonWidth = (pnlItem.Width - (int)buttonPadding) / _Categories.Count;

            // Padding between buttons : 16
            foreach (var product in products)
            {
                if (index == 0)
                {
                    currentLocationY += 3;
                    InitializeItemsButton(product.Product, dynamicButtonWidth, 16, currentLocationY);
                }
                else if (index % 3 == 0)
                {
                    currentLocationY += 86 + 8;
                    InitializeItemsButton(product.Product, dynamicButtonWidth, 16, currentLocationY);
                }
                else
                    InitializeItemsButton(product.Product, dynamicButtonWidth, (dynamicButtonWidth * index) + (16 * index) + 16, currentLocationY);
                index++;
            }
        }

        private void InitializeItemsButton(string name, int dynamicButtonWidth, int locationX, int locationY)
        {
            _DynamicItemButton = new Button();
            // Set Button Properties
            _DynamicItemButton.Width = dynamicButtonWidth;
            _DynamicItemButton.Height = 86;
            //_DynamicButton.Dock = DockStyle.Top;
            _DynamicItemButton.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            _DynamicItemButton.Location = new Point(locationX, locationY);

            // Set Background and Foreground 
            _DynamicItemButton.BackColor = Color.FromArgb(143, 185, 168);
            _DynamicItemButton.ForeColor = Color.White;

            _DynamicItemButton.Text = name;
            _DynamicItemButton.Name = name;
            _DynamicItemButton.Font = new Font("Café Françoise", 14, FontStyle.Bold);

            // Add a Button Click Event handler
            _DynamicItemButton.Click += new EventHandler(DynamicItemButton_Click);
            pnlItem.Controls.Add(_DynamicItemButton);
        }

        private void GetProducts()
        {
            Cafe cafe = new Cafe();
            _Products = new List<ProductDTO>();
            _Products = cafe.GetProducts();
        }

        private void InitializeCategoryButton(string name, int dynamicButtonWidth, int locationX)
        {
            _DynamicButton = new Button();
            // Set Button Properties
            _DynamicButton.Width = dynamicButtonWidth;
            _DynamicButton.Height = 86;
            //_DynamicButton.Dock = DockStyle.Top;
            _DynamicButton.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            _DynamicButton.Location = new Point(locationX, 9);

            // Set Background and Foreground 
            _DynamicButton.BackColor = Color.FromArgb(143, 185, 168);
            _DynamicButton.ForeColor = Color.White;

            _DynamicButton.Text = name;
            _DynamicButton.Name = name;
            _DynamicButton.Font = new Font("Café Françoise", 14, FontStyle.Bold);

            // Add a Button Click Event handler
            _DynamicButton.Click += new EventHandler(DynamicButton_Click);
            pnlCategory.Controls.Add(_DynamicButton);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            pnlItem.Controls.Clear();
            Button btn = sender as Button;
            GetItems(btn.Name);
        }

        private void DynamicItemButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            var selectedProduct = _Products.Find(x => x.Product == btn.Name);
            var selectedItem = _SelectedItems.Find(x => x.ProductName == btn.Name);

            if (selectedItem == null)
            {
                TransactionDTO transaction = new TransactionDTO();
                transaction.Price = selectedProduct.Price;
                transaction.ProductName = selectedProduct.Product;
                transaction.Quantity += 1;

                _SelectedItems.Add(transaction);
            }
            else
            {
                selectedItem.Quantity += 1;
            }
            PreviewSelectedItems();
        }

        private void PreviewSelectedItems()
        {
            Dictionary<string, string> selectedItems = new Dictionary<string, string>();

            decimal totalPrice = 0;
            decimal itemPrice = 0;
            int totalItems = 0;
            foreach (var item in _SelectedItems)
            {
                totalItems += item.Quantity;
                itemPrice += item.Price * item.Quantity;
                selectedItems.Add(item.ProductName, itemPrice.ToString());
                //lstItems.Items.Add(string.Format(_ListFormat, item.ProductName, itemPrice));
                totalPrice += itemPrice;
                itemPrice = 0;
            }

            decimal totalNET = totalPrice * (decimal)0.12;
            decimal totalVAT = totalPrice - (totalPrice * (decimal)0.12);

            lblTotalPrice.Text = totalPrice.ToString();
            lblTotalItems.Text = totalItems.ToString();
            lblNET.Text = totalNET.ToString();
            lblVAT.Text = totalVAT.ToString();

            _TotalPrice = totalPrice;

            RefreshDataGrid(selectedItems);
        }

        private void RefreshDataGrid(Dictionary<string, string> items)
        {
            dgItems.DataSource = items.ToList();
            dgItems.Refresh();
        }

        private void frmCashRegister_Load(object sender, EventArgs e)
        {
            GetCategories();
            GetProducts();
            LblUsername.Text = _Username;
        }

        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            Random random = new Random();
            string amount = "";
            Input.InputBox("CHECK OUT NOW?", "Enter the amount:", ref amount);

            MessageBox.Show("Change: " + (Convert.ToDecimal(amount) - _TotalPrice) + Environment.NewLine + 
                "Thank you!", "CHANGE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string receipt = DateTime.Today.ToString("MM") + random.Next(100000).ToString() + DateTime.Today.ToString("dd") +
                random.Next(10000).ToString() + DateTime.Today.ToString("yyyy");

            List<Transaction> transactions = new List<Transaction>();

            if (_SelectedItems.Count > 0)
            {
                foreach (var item in _SelectedItems)
                {
                    Transaction transaction = new Transaction()
                    {
                        Quantity = item.Quantity,
                        ReceiptNumber = receipt,
                        ProductId = _Products.Find(x => x.Product == item.ProductName).ProductId,
                        UserId = cafe.GetUserIdByName(_Username)
                    };
                    transactions.Add(transaction);
                }
            }

            string message = cafe.AddTransaction(transactions);

            if (message.Contains("Pass"))
            {
                MessageBox.Show("Transaction successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _SelectedItems.Clear();
                PreviewSelectedItems();
            }
                
            else
                MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Need Print receipt

        }

        private void dgItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgItems.RowHeadersVisible = false;
            dgItems.Columns[0].HeaderText = "Product"; 
            dgItems.Columns[1].HeaderText = "Price";
        }

        private void dgItems_SelectionChanged(object sender, EventArgs e)
        {
            if (_SelectedItems.Count > 0)
            {
                _SelectedItem = new TransactionDTO();
                _SelectedItem = _SelectedItems.Find(x => x.ProductName == dgItems.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void BtnVoid_Click(object sender, EventArgs e)
        {
            if (_SelectedItem != null)
                _SelectedItems.Remove(_SelectedItem);
            PreviewSelectedItems();
        }

        private void frmCashRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            this.Hide();
            form.Show();

        }
    }
}
