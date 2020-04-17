using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class PearsonCorrelationConfiguration : IEntityTypeConfiguration<PearsonCorrelation>
    {
        public void Configure(EntityTypeBuilder<PearsonCorrelation> builder)
        {
            builder.Property(x => x.UserId)
                .IsRequired();

            builder.Property(x => x.CompareUserId)
                .IsRequired();

            builder.Property(x => x.Score)
                .HasColumnType("decimal(7,6)")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(y => y.UserPearsonCorrelations)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_PearsonCorrelations_User");

            builder.HasOne(x => x.CompareUser)
                .WithMany(y => y.CompareUserPearsonCorrelations)
                .HasForeignKey(x => x.CompareUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_PearsonCorrelations_CompareUser");
        }
    }
}
