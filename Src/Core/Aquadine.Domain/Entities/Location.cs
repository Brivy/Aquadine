using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LocationLink { get; set; }

        public string ProductDescription { get; set; }

        public decimal DeliveryCost { get; set; }

        public decimal DeliveryMinOrder { get; set; }


        public ICollection<Order> Orders { get; set; } 

        public ICollection<Location> Locations { get; set; }
    }
}
