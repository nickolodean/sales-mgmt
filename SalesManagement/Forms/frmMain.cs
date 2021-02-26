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
    public partial class frmMain : Form
    {
        private string _Username;

        public frmMain(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnCashRegister_Click(object sender, EventArgs e)
        {
            frmCashRegister form = new frmCashRegister(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnUserSetting_Click(object sender, EventArgs e)
        {
            frmUser form = new frmUser(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnTransaction_Click(object sender, EventArgs e)
        {
            frmTransaction form = new frmTransaction(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            frmCategory form = new frmCategory(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnSupplier_Click(object sender, EventArgs e)
        {
            SupplierForm form = new SupplierForm(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventory form = new frmInventory(_Username);
            form.Show();
            this.Hide();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            frmMainD form = new frmMainD(_Username);
            form.Show();
            this.Hide();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogIn frmLogIn = new frmLogIn();
            Hide();
            frmLogIn.Show();
        }
    }
}
