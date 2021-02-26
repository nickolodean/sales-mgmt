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
using System.Windows.Forms.DataVisualization.Charting;

namespace SalesManagement.Forms
{
    public partial class frmMainD : Form
    {
        private List<TransactionDTO> _Transactions;
        private string _Username;

        public frmMainD(string username)
        {
            InitializeComponent();
            _Username = username;
        }

        private void GetTransactions()
        {
            Cafe cafe = new Cafe();
            _Transactions = new List<TransactionDTO>();
            _Transactions = cafe.GetTransactions();
        }

        private void LoadCharts()
        {
            //chart.Legends.Add("Date By ")
        }


        private void frmMainD_Load(object sender, EventArgs e)
        {
            GetTransactions();
            var perDay = _Transactions.GroupBy(x => new { x.TransactionDate })
                     .Select(x => new
                     {
                         TransactionDate = x.Key.TransactionDate,
                         Receipt = x.Select(z => z.ReceiptNumber).Distinct().ToList(),
                         //Product = x.Select(z => z.ProductName),
                         Price = x.Sum(z => z.Price),
                         Quantity = x.Sum(z => z.Quantity)
                     }).ToList();

            // Prices per Transaction Date Chart
            var perMonthTransactions = pricePerMonthChart.Series["PerMonthSeries"];

            if (perDay.Count > 0)
                foreach (var transactions in perDay)
                    perMonthTransactions.Points.AddXY(transactions.TransactionDate, transactions.Price);


            // Quantity used per Transaction Date
            var quantityPerDay = quantityChart.Series["QuantitySeries"];

            if (perDay.Count > 0)
                foreach (var transactions in perDay)
                    quantityPerDay.Points.AddXY(transactions.TransactionDate, transactions.Quantity);

            // Transactions Quantity Per day
            var recPerDay = receiptPerDay.Series["RecSeries"];

            if (perDay.Count > 0)
                foreach (var transactions in perDay)
                    recPerDay.Points.AddXY(transactions.TransactionDate, transactions.Receipt.Count);


            var perMonth = _Transactions.GroupBy(x => new { MonthDate = x.TransactionDate.ToString("MMM") })
                     .Select(x => new
                     {
                         TransactionDate = x.Key.MonthDate,
                         Receipt = x.Select(z => z.ReceiptNumber).Distinct().ToList(),
                         //Product = x.Select(z => z.ProductName),
                         Price = x.Sum(z => z.Price),
                         Quantity = x.Sum(z => z.Quantity)
                     }).ToList();


            // Transactions Quantity Per Month
            var salesPerMM = salesPerMonth.Series["SalesPerMonthSeries"];

            if (perMonth.Count > 0)
                foreach (var transactions in perMonth)
                    salesPerMM.Points.AddXY(transactions.TransactionDate, transactions.Price);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(_Username);
            Hide();
            frmMain.Show();
        }
    }
}
