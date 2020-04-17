using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.IngredientId).IsRequired();

            builder.Property(x => x.Score)
                .HasColumnType("decimal(7,6)")
                .IsRequired();
        }
    }
}
