﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Demo.Infrastructure.Persistence.Records;

namespace Optivem.Demo.Infrastructure.Persistence.Configuration
{
    public class OrderStatusRecordConfiguration : IEntityTypeConfiguration<OrderStatusRecord>
    {
        public void Configure(EntityTypeBuilder<OrderStatusRecord> builder)
        {
            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}