namespace Aquadine.Domain.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public short Amount { get; set; }


        public Order Order { get; set; }

        public User User { get; set; }
        
        public Product Product { get; set; }
    }
}
