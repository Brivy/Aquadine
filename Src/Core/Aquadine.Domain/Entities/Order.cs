using System;

namespace Aquadine.Domain.Entities
{
    class Order
    {
        public int Id { get; set; }

        public int LocationId { get; set; }

        public double Price { get; set; }

        public DateTime DateOrderd { get; set; }

        public DateTime DateCompleted { get; set; }
    }
}
