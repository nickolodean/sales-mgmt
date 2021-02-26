using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stocks { get; set; }

    }
}
