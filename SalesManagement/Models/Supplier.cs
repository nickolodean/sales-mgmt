namespace SalesManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Landline { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
