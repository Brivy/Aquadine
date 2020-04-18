using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(y => y.Favorites)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Favorites_Users");

            builder.HasOne(x => x.Product)
                .WithMany(y => y.Favorites)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Favorites_Products");
        }
    }
}
