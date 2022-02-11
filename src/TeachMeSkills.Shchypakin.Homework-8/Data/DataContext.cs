﻿using Masny.TimeTracker.Data.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeachMeSkills.Shchypakin.Homework_8.Configurations;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Data
{
    public class DataContext : IdentityDbContext<Client, AppRole, int,
        IdentityUserClaim<int>, AppUserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<MembershipHistoryRecord> MembershipHistoryRecords { get; set; }

        public DbSet<MembershipSize> MembershipSizes { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ApplyConfiguration(new ClientConfiguration());
            builder.ApplyConfiguration(new AppRoleConfiguration());
            builder.ApplyConfiguration(new MembershipSizeConfiguration());
            builder.ApplyConfiguration(new MembershipTypeConfiguration());
            builder.ApplyConfiguration(new MembershipConfiguration());
            builder.ApplyConfiguration(new RecordConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
