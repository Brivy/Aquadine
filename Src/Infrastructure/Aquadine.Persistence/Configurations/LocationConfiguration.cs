using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    internal class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.LocationLink)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.ProductDescription)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.DeliveryCost)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(x => x.DeliveryMinOrder)
                .HasColumnType("money")
                .IsRequired();
        }
    }
}
