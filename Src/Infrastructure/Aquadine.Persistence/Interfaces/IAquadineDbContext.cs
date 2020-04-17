using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aquadine.Persistence.Interfaces
{
    interface IAquadineDbContext
    {
        DbSet<Favorite> Favorites { get; set; }

        DbSet<Ingredient> Ingredients { get; set; }

        DbSet<Location> Locations { get; set; }

        DbSet<NearestNeighbor> NearestNeighbors { get; set; }

        DbSet<Order> Orders { get; set; }

        DbSet<OrderDetail> OrderDetails { get; set; }

        DbSet<PearsonCorrelation> PearsonCorrelations { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<ProductIngredient> ProductIngredients { get; set; }

        DbSet<User> Users { get; set; }

        DbSet<UserProfile> UserProfiles { get; set; }
    }
}
