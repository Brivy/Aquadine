using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.OrderId).IsRequired();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.Productid).IsRequired();

            builder.Property(x => x.Amount).IsRequired();
        }
    }
}
