using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    internal class ProductIngredientConfiguration : IEntityTypeConfiguration<ProductIngredient>
    {
        public void Configure(EntityTypeBuilder<ProductIngredient> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.IngredientId).IsRequired();

            builder.Property(x => x.Percentage)
                .HasColumnType("decimal(7,6)")
                .IsRequired();

            builder.Property(x => x.Amount).IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany(y => y.ProductIngredients)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Product_Ingredients_Products");

            builder.HasOne(x => x.Ingredient)
                .WithMany(y => y.ProductIngredients)
                .HasForeignKey(x => x.IngredientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Product_Ingredients_Ingredients");
        }
    }
}
