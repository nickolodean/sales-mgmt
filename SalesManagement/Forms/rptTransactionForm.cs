using Microsoft.Reporting.WinForms;
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
    public partial class rptTransactionForm : Form
    {
        private DateTime _DateFrom;
        private DateTime _DateTo;
        private List<TransactionDTO> _Transactions;

        public rptTransactionForm(DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            _DateFrom = dateFrom;
            _DateTo = dateTo;
        }

        private void GetTransactions()
        {
            Cafe cafe = new Cafe();
            _Transactions = new List<TransactionDTO>();
            _Transactions = cafe.GetTransactions();
        }

        private void rptTransactionForm_Load(object sender, EventArgs e)
        {
            GetTransactions();
            PreviewReport();
            this.rptViewer.RefreshReport();
            this.rptViewer.RefreshReport();
        }

        private void PreviewReport()
        {
            string reportPath = AppDomain.CurrentDomain.BaseDirectory + @"Reports\rptTransaction.rdlc";

            var transactions = (from transaction in _Transactions
                                where transaction.TransactionDate.Date >= _DateFrom.Date
                                && transaction.TransactionDate.Date <= _DateTo.Date
                                select transaction).ToList();

            rptViewer.LocalReport.ReportPath = reportPath;
            rptViewer.LocalReport.DataSources.Add(new ReportDataSource("TransactionSet", transactions));
            rptViewer.LocalReport.Refresh();
            rptViewer.RefreshReport();

            //string deviceInfo = @"<DeviceInfo>
            //                        <OutputFormat>EMF</OutputFormat>
            //                        <PageWidth>8.27in</PageWidth>
            //                        <PageHeight>11.69in</PageHeight>
            //                        <MarginTop>0.0in</MarginTop>
            //                        <MarginLeft>0.0in</MarginLeft>
            //                        <MarginRight>0.0in</MarginRight>
            //                        <MarginBottom>0.0in</MarginBottom>
            //                    </DeviceInfo>";
            // Reciept width size 3.14961in
        }

    }
}
