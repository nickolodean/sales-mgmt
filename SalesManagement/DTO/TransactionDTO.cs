using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.DTO
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }
        public string Username { get; set; }
        public string ProductName { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public string ReceiptNumber { get; set; }

    }
}
