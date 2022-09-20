using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class RestaurantDishesDto
    {
        public int Id { get; set; }
        public string RestaurantName { get; set; }
        public List<ProductDto> Dishes { get; set; }
    }
}
