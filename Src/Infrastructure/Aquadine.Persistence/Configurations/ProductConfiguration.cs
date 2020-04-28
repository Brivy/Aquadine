using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.LocationId).IsRequired();

            builder.Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Category)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Property(x => x.IngredientChoice)
                .HasMaxLength(1000);

            builder.Property(x => x.Price)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(x => x.IsActive)
                .HasDefaultValueSql("((0))")
                .IsRequired();

            builder.Property(x => x.LastChanged)
                .HasColumnType("datetime")
                .IsRequired();

            builder.HasOne(x => x.Location)
                .WithMany(y => y.Products)
                .HasForeignKey(x => x.LocationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Products_Locations");
        }
    }
}
