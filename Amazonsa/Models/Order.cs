using System;
using System.Collections.Generic;

namespace amazonsa.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; } 
        public DateTime OrderDate { get; set; }
        public List<OrderDetails> OrderDetailsList { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
