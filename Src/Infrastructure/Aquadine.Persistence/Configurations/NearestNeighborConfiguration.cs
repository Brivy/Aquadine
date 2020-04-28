using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class NearestNeighborConfiguration : IEntityTypeConfiguration<NearestNeighbor>
    {
        public void Configure(EntityTypeBuilder<NearestNeighbor> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.Score)
                .HasColumnType("decimal(7,6)")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(y => y.NearestNeighbors)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Nearest_Neighbors_Users");

            builder.HasOne(x => x.Product)
                .WithMany(y => y.NearestNeighbors)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Nearest_Neighbors_Products");
        }
    }
}
