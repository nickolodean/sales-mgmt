using SalesManagement.DTO;
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
    public partial class frmTransaction : Form
    {
        //private Dictionary<string, List<TransactionDTO>> _Transactions;
        private List<TransactionDTO> _Transactions;
        private string _Username;
        private DateTime _DateFrom;
        private DateTime _DateTo;

        public frmTransaction(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void GetTransactions()
        {
            Cafe cafe = new Cafe();
            _Transactions =  new List<TransactionDTO>();
            _Transactions = cafe.GetTransactions();
        }

        private void RefreshData()
        {
            GetTransactions();
            DGTransaction.DataSource = _Transactions;
            DGTransaction.Refresh();
            LblTotalTransactions.Text = _Transactions.Count().ToString();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            RefreshData();
            _DateFrom = DTDateFrom.Value;
            _DateTo = DTDateTo.Value;
        }

        private void DTDateTo_ValueChanged(object sender, EventArgs e)
        {
            DTDateFrom.MaxDate = DTDateTo.Value;
            var transactions = _Transactions.Where(x => x.TransactionDate.Date >= DTDateFrom.Value.Date
                                        && x.TransactionDate.Date <= DTDateTo.Value.Date).ToList();

            DGTransaction.DataSource = transactions;
            DGTransaction.Refresh();
            LblTotalTransactions.Text = transactions.Count().ToString();
            _DateTo = DTDateTo.Value;
        }

        private void DTDateFrom_ValueChanged(object sender, EventArgs e)
        {
            DTDateTo.MinDate = DTDateFrom.Value;
            var transactions = _Transactions.Where(x => x.TransactionDate.Date >= DTDateFrom.Value.Date
                                        && x.TransactionDate.Date <= DTDateTo.Value.Date).ToList();

            DGTransaction.DataSource = transactions;
            DGTransaction.Refresh();
            LblTotalTransactions.Text = transactions.Count().ToString();
            _DateFrom = DTDateFrom.Value;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.TextLength <= 0) RefreshData();
            else
            {
                var transactions = _Transactions.Where(x => x.ProductName.ToLower().Contains(TxtSearch.Text) 
                || x.ReceiptNumber.ToLower().Contains(TxtSearch.Text)).ToList();

                DGTransaction.DataSource = transactions;
                DGTransaction.Refresh();
                LblTotalTransactions.Text = transactions.Count().ToString();
            }
        }

        private void frmTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain form = new frmMain(_Username);
            Hide();
            form.Show();
        }

        private void BtnPrintReport_Click(object sender, EventArgs e)
        {
            rptTransactionForm form = new rptTransactionForm(_DateFrom, _DateTo);
            form.ShowDialog();
        }
    }
}
