using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class NearestNeighborConfiguration : IEntityTypeConfiguration<NearestNeighbor>
    {
        public void Configure(EntityTypeBuilder<NearestNeighbor> builder)
        {
            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.Score)
                .HasColumnType("decimal(7,6)")
                .IsRequired();
        }
    }
}
