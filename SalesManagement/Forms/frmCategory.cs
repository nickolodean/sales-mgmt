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
    public partial class frmCategory : Form
    {
        private int _CategoryId = 0;
        private string _Username;
        public frmCategory(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            TxtCategory.Clear();
        }

        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCategory.Text))
            {
                Cafe cafe = new Cafe();
                string message = cafe.AddCategory(TxtCategory.Text);
                RefreshDataGrid();
            }
            else MessageBox.Show("Please enter a category! Field must not be empty.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            TxtCategory.Clear();
        }

        private void TxtCategoryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) BtnAdd.PerformClick();
        }

        private void RefreshDataGrid()
        {
            Cafe cafe = new Cafe();
            DGCategory.DataSource = cafe.GetAllCategory().Select(x => new 
            { 
                x.CategoryId,
                x.CategoryName
            }).ToList();
            DGCategory.Refresh();
            TxtCategory.Clear();
        }


        private void DGView_SelectionChanged(object sender, EventArgs e)
        {
            TxtCategory.Text = DGCategory.CurrentRow.Cells[1].Value.ToString();
            _CategoryId = Convert.ToInt32(DGCategory.CurrentRow.Cells[0].Value);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_CategoryId > 0)
            {
                Cafe cafe = new Cafe();
                string message = cafe.UpdateCategory(_CategoryId, TxtCategory.Text);
                if (!message.Contains("Pass")) MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _CategoryId = 0;
                RefreshDataGrid();
            }
        }

        private void DGView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //DGCategory.Columns[0].Visible = false;
            if (DGCategory.Rows.Count > 0) DGCategory.Rows[0].Selected = false;
            TxtCategory.Clear();
            DGCategory.RowHeadersVisible = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete this category?", "WARNING",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (_CategoryId > 0)
            {
                Cafe cafe = new Cafe();
                string message = cafe.DeleteCategory(_CategoryId);
                if (!message.Contains("Pass")) MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _CategoryId = 0;
                RefreshDataGrid();
            }
        }

        private void frmCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            Hide();
            form.Show();
        }
    }
}
