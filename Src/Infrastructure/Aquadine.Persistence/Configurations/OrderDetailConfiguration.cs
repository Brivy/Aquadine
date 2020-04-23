using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    internal class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.OrderId).IsRequired();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.Property(x => x.Amount).IsRequired();

            builder.HasOne(x => x.Order)
                .WithMany(y => y.OrderDetails)
                .HasForeignKey(x => x.OrderId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Order_Details_Orders");

            builder.HasOne(x => x.User)
                .WithMany(y => y.OrderDetails)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Order_Details_Users");

            builder.HasOne(x => x.Product)
                .WithMany(y => y.OrderDetails)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Order_Details_Products");
        }
    }
}
