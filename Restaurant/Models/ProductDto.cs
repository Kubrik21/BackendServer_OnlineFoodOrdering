using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ProductDto
    {
        public int ProductId { get; set; }
        public string ProductCategory { get; set; }
        public string ProductName { get; set; }
        public string ProductLogo { get; set; }
        public float ProductPrice { get; set; }
    }
}
