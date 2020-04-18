using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.IngredientId).IsRequired();

            builder.Property(x => x.Score)
                .HasColumnType("decimal(7,6)")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(y => y.UserProfiles)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_User_Profiles_Users");

            builder.HasOne(x => x.Ingredient)
                .WithMany(y => y.UserProfiles)
                .HasForeignKey(x => x.IngredientId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_User_Profiles_Ingredients");           
        }
    }
}
