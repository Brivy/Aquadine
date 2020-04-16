namespace Aquadine.Domain.Entities
{
    class Purchase
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int UserId { get; set; }

        public int Productid { get; set; }

        public int Amount { get; set; }
    }
}
