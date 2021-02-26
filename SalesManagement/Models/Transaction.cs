namespace SalesManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public int UserId { get; set; }

        public DateTime TransactionDate { get; set; }

        public int Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceiptNumber { get; set; }
    }
}
