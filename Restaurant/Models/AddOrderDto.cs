using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class AddOrderDto
    {
        [Required]
        [MaxLength(50)]
        public string OrderName { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrderSurname { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrderMail { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrderAdres { get; set; }
        public string OrderAdresSec { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrderPostCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string OrderCity { get; set; }
        public List<OrderElement> OrdersElements { get; set; }
    }
}
