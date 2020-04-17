using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class User
    {
        public User()
        {
            Favorites = new HashSet<Favorite>();
            OrderDetails = new HashSet<OrderDetails>();
            NearestNeighbors = new HashSet<NearestNeighbor>();
            UserPearsonCorrelations = new HashSet<PearsonCorrelation>();
            CompareUserPearsonCorrelations = new HashSet<PearsonCorrelation>();
            UserProfiles = new HashSet<UserProfile>();
        }

        public int Id { get; set; }


        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ICollection<NearestNeighbor> NearestNeighbors { get; set; }

        public ICollection<PearsonCorrelation> UserPearsonCorrelations { get; set; }

        public ICollection<PearsonCorrelation> CompareUserPearsonCorrelations { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
