using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();
        }
    }
}
