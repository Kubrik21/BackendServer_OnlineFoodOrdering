using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderSurname { get; set; }
        public string OrderMail { get; set; }
        public string OrderAdres { get; set; }
        public string OrderAdresSec { get; set; }
        public string OrderPostCode { get; set; }
        public string OrderCity { get; set; }
        public List<OrderElement> OrdersElements { get; set; }
        //public virtual Restaurantt Restaurant { get; set; } //Dzieki temu będe miał pełen widok odwołując się
    }
}
