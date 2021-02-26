namespace SalesManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AuditTransactionView")]
    public partial class AuditTransactionView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransactionId { get; set; }

        [Key]
        [Column("Product Name", Order = 1)]
        [StringLength(50)]
        public string Product_Name { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Username { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Quantity { get; set; }

        [Key]
        [Column("Transaction Date", Order = 5)]
        public DateTime Transaction_Date { get; set; }
    }
}
