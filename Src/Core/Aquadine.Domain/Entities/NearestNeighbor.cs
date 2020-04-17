namespace Aquadine.Domain.Entities
{
    public class NearestNeighbor
    {
        public int UserId { get; set; }

        public int ProductId { get; set; }

        public double Score { get; set; }


        public User User { get; set; }

        public Product Product { get; set; }
    }
}
