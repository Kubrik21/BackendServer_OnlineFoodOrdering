using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models
{
    public class ShowOrdersDto
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderSurname { get; set; }
        public string OrderMail { get; set; }
        public string OrderAdres { get; set; }
        public string OrderAdresSec { get; set; }
        public string OrderPostCode { get; set; }
        public string OrderCity { get; set; }
      

    }
}
