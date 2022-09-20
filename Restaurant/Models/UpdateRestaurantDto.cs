using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class UpdateRestaurantDto
    {
        [Required]
        [MaxLength(50)]
        public string RestaurantName { get; set; }
        public string RestaurantMotto { get; set; }
        public string RestaurantLogo { get; set; }
    }
}
