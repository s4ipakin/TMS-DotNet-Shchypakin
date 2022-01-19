using Microsoft.EntityFrameworkCore;
using TeachMeSkills.Shchypakin.Homework_8.Entities;

namespace TeachMeSkills.Shchypakin.Homework_8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Membership> Memberships { get; set; }

        public DbSet<MembershipHistory> MembershipHistories { get; set; }

        public DbSet<MembershipSize> MembershipSizes { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }
    }
}
