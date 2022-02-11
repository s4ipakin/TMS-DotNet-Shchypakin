using Masny.TimeTracker.Data.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace Masny.TimeTracker.Data.Configurations
{
    /// <summary>
    /// EF Configuration for Goal entity.
    /// </summary>
    public class MembershipSizeConfiguration : IEntityTypeConfiguration<MembershipSize>
    {
        public void Configure(EntityTypeBuilder<MembershipSize> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.MembershipSizes, Schema.Membership)
                .HasKey(size => size.Id);

            builder.Property(size => size.Id)
                .UseIdentityColumn();

            builder.Property(size => size.Count).IsRequired();

            builder.Property(size => size.Comment)
                .HasMaxLength(SqlConfiguration.SqlMaxLengthLong);

        }
    }
}
