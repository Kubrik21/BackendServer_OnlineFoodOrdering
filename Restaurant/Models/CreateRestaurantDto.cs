using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class CreateRestaurantDto
    {
        [Required]
        [MaxLength(50)]
        public string RestaurantName { get; set; }
        public string RestaurantMotto { get; set; }

        public string restaurantLogo { get; set; }
        [Required]
        public float RestaurantMinValue { get; set; }
        [Required]
        public float RestaurantDelivery { get; set; }

        
    }
}
