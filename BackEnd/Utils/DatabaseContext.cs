using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Utils
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<IDCard> IdCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Account - Role relationship (one-to-many)
            modelBuilder
                .Entity<Account>()
                .HasOne(a => a.Role)
                .WithMany(r => r.Accounts)
                .HasForeignKey(a => a.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            // Account - IDCard relationship (one-to-one)
            modelBuilder
                .Entity<Account>()
                .HasOne(a => a.IdCard)
                .WithOne(i => i.Account)
                .HasForeignKey<IDCard>("AccountId")
                .OnDelete(DeleteBehavior.Cascade);

            // Role - Permission relationship (many-to-many)
            modelBuilder
                .Entity<Role>()
                .HasMany(r => r.Permissions)
                .WithMany(p => p.Roles)
                .UsingEntity(j => j.ToTable("RolePermissions"));

            // Seed data for Roles
            modelBuilder
                .Entity<Role>()
                .HasData(
                    new Role
                    {
                        Id = 1,
                        Name = "Admin",
                        Description = "Administrator role with full permissions",
                    },
                    new Role
                    {
                        Id = 2,
                        Name = "User",
                        Description = "Regular user role",
                    },
                    new Role
                    {
                        Id = 3,
                        Name = "Moderator",
                        Description = "Moderator role with limited admin permissions",
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
