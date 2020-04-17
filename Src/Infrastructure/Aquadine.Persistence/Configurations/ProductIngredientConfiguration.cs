using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class ProductIngredientConfiguration : IEntityTypeConfiguration<ProductIngredient>
    {
        public void Configure(EntityTypeBuilder<ProductIngredient> builder)
        {
            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.IngredientId).IsRequired();

            builder.Property(x => x.Percentage)
                .HasColumnType("decimal(7,6)")
                .IsRequired();

            builder.Property(x => x.Amount).IsRequired();
        }
    }
}
