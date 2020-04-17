using System.Collections.Generic;

namespace Aquadine.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public ICollection<Favorite> Favorites { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }

        public ICollection<NearestNeighbor> NearestNeighbors { get; set; }

        public ICollection<PearsonCorrelation> UserPearsonCorrelations { get; set; }

        public ICollection<PearsonCorrelation> CompareUserPearsonCorrelations { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
