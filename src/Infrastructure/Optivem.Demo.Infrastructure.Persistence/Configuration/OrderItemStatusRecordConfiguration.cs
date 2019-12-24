﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Demo.Infrastructure.Persistence.Records;

namespace Optivem.Demo.Infrastructure.Persistence.Configuration
{
    public class OrderItemStatusRecordConfiguration : IEntityTypeConfiguration<OrderItemStatusRecord>
    {
        public void Configure(EntityTypeBuilder<OrderItemStatusRecord> builder)
        {
            builder.Property(e => e.Id)
                .HasConversion<byte>();

            builder.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}