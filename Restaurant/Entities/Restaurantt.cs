using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Restaurant.Entities
{
    public class Restaurantt
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantMotto { get; set; }

        public string restaurantLogo { get; set; }

        public float RestaurantMinValue { get; set; } 
        
        public float RestaurantDelivery { get; set; }   

        public virtual List<Product> Dishes { get; set; }
    }
}
