﻿using Microsoft.EntityFrameworkCore;
using Aquadine.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aquadine.Persistence.Configurations
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.LocationId).IsRequired();

            builder.Property(x => x.TotalPrice)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(x => x.DateOrderd)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(x => x.DateCompleted)
                .HasColumnType("datetime");
        }
    }
}