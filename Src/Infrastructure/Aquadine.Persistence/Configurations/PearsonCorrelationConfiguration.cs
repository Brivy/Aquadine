using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class PearsonCorrelationConfiguration : IEntityTypeConfiguration<PearsonCorrelation>
    {
        public void Configure(EntityTypeBuilder<PearsonCorrelation> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

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
                .HasConstraintName("FK_Pearson_Correlations_Users");

            builder.HasOne(x => x.CompareUser)
                .WithMany(y => y.CompareUserPearsonCorrelations)
                .HasForeignKey(x => x.CompareUserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Pearson_Correlations_Compare_Users");
        }
    }
}
