using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class RestauranttDto
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantMotto { get; set; }

        public string restaurantLogo { get; set; }

        public float RestaurantMinValue { get; set; }

        public float RestaurantDelivery { get; set; }

        public List<ProductDto> Dishes { get; set; }
    }
}
