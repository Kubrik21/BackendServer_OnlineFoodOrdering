using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Restaurant.Entities

{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductCategory { get; set; } 
        public string ProductName   { get; set; }   
        public string ProductLogo { get; set; }
        public float ProductPrice { get; set; }

        public int RestaurantID { get; set; }
        public List<OrderElement> OrdersElements { get; set; }
        public virtual Restaurantt Restaurant { get; set; } //Dzieki temu będe miał pełen widok odwołując się
                                                        
        
    }
}
