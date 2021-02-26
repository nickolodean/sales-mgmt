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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void GetAllUsers()
        {
            Cafe cafe = new Cafe();
            var test = cafe.GetUsers();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text) || !string.IsNullOrEmpty(TxtUsername.Text))
            {
                Cafe cafe = new Cafe();
                string message = cafe.VerifyAccount(TxtUsername.Text, TxtPassword.Text);
                if (message.Contains("Pass"))
                {
                    frmMain form = new frmMain(TxtUsername.Text);
                    form.Show();
                    this.Hide();
                }
                else MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
