using Masny.TimeTracker.Data.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace Masny.TimeTracker.Data.Configurations
{
    /// <summary>
    /// EF Configuration for Project entity.
    /// </summary>
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(Table.Memberships, Schema.Membership)
                .HasKey(membership => membership.Id);

            builder.Property(membership => membership.Id)
                .UseIdentityColumn();

            builder.Property(membership => membership.Start)
                .IsRequired()
                .HasColumnType(SqlConfiguration.SqlDateFormat);

            builder.Property(membership => membership.End)
                .IsRequired()
                .HasColumnType(SqlConfiguration.SqlDateFormat);

            builder.Property(membership => membership.IsActive).IsRequired();

            builder.HasOne(membership => membership.Client)
                .WithMany(client => client.Memberships)
                .HasForeignKey(membership => membership.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(membership => membership.MembershipSize)
                .WithMany(size => size.Memberships)
                .HasForeignKey(membership => membership.MembershipSizeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(membership => membership.MembershipType)
                .WithMany(type => type.Memberships)
                .HasForeignKey(membership => membership.MembershipTypeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
