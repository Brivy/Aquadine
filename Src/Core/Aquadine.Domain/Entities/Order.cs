using System;
using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Id { get; set; }

        public int LocationId { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime DateOrderd { get; set; }

        public DateTime? DateCompleted { get; set; }


        public Location Location { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
