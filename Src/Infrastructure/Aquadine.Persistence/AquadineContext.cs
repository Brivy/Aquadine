using Aquadine.Domain.Entities;
using Aquadine.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Aquadine.Persistence
{
    internal class AquadineContext : DbContext, IAquadineContext
    {
        public AquadineContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<NearestNeighbor> NearestNeighbors { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<PearsonCorrelation> PearsonCorrelations { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductIngredient> ProductIngredients { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
