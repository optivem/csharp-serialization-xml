﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Demo.Infrastructure.Persistence.Records;

namespace Optivem.Demo.Infrastructure.Persistence.Configuration
{
    public class CustomerRecordConfiguration : IEntityTypeConfiguration<CustomerRecord>
    {
        public void Configure(EntityTypeBuilder<CustomerRecord> builder)
        {
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}