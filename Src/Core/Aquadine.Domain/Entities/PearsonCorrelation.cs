namespace Aquadine.Domain.Entities
{
    public class PearsonCorrelation
    {
        public int UserId { get; set; }

        public int CompareUserId { get; set; }

        public double Score { get; set; }


        public User User { get; set; }

        public User CompareUser { get; set; }
    }
}
