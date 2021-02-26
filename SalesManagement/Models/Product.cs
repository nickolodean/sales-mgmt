namespace SalesManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProductPrice { get; set; }

        public int CategoryId { get; set; }

        public int SupplierId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public virtual Category Category { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
