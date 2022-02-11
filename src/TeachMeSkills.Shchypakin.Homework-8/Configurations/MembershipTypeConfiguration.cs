using Masny.TimeTracker.Data.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Configurations
{
    public class MembershipTypeConfiguration : IEntityTypeConfiguration<MembershipType>
    {
        public void Configure(EntityTypeBuilder<MembershipType> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.MembershipTypes, Schema.Membership)
                .HasKey(type => type.Id);

            builder.Property(type => type.Id)
                .UseIdentityColumn();

            builder.Property(type => type.Type)
                .IsRequired()
                .HasMaxLength(SqlConfiguration.SqlMaxLengthShort);
        }
    }
}
