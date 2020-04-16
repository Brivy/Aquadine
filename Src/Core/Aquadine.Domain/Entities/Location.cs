namespace Aquadine.Domain.Entities
{
    class Location
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Href { get; set; }

        public string Kitchen { get; set; }

        public double DeliveryCost { get; set; }

        public double DeliveryMinOrder { get; set; }
    }
}
