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
    public partial class frmUser : Form
    {
        private List<User> _Users;
        private User _SelectedUser;
        private string _Username;

        public frmUser(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void GetUsers()
        {
            Cafe cafe = new Cafe();
            _Users = new List<User>();
            _Users = cafe.GetUsers();
        }

        private void RefreshDataGrid()
        {
            GetUsers();
            DGUser.DataSource = _Users;
            DGUser.Refresh();
        }

        private void ClearText()
        {
            TxtPassword.Clear();
            TxtUsername.Clear();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchUser = _Users.Where(x => x.Username.Contains(TxtSearch.Text)).ToList();
            DGUser.DataSource = searchUser;
            DGUser.Refresh();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            string message = cafe.Hash(TxtUsername.Text, TxtPassword.Text);

            if (message.Contains("Pass"))
                MessageBox.Show("User successfully added!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DGUser.CurrentRow.Selected = false;
            RefreshDataGrid();
            ClearText();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            string message = cafe.UpdateUser(TxtUsername.Text, TxtPassword.Text, _SelectedUser.UserId);

            if (message.Contains("Pass"))
                MessageBox.Show("User successfully updated!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DGUser.CurrentRow.Selected = false;
            RefreshDataGrid();
            ClearText();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Cafe cafe = new Cafe();
            string message = cafe.DeleteUser(_SelectedUser.UserId);

            if (message.Contains("Pass"))
                MessageBox.Show("User successfully deleted!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DGUser.CurrentRow.Selected = false;
            RefreshDataGrid();
            ClearText();
        }

        private void DGUser_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DGUser.RowHeadersVisible = false;
            ClearText();
        }

        private void DGUser_SelectionChanged(object sender, EventArgs e)
        {
            if (_Users.Count > 0)
            {
                _SelectedUser = new User
                {
                    Username = DGUser.CurrentRow.Cells[1].Value.ToString(),
                    Password = " ",
                    UserId = _Users.Find(x => x.Username == DGUser.CurrentRow.Cells[1].Value.ToString().Trim()).UserId
                };
                TxtUsername.Text = DGUser.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            Hide();
            form.Show();
        }
    }
}
