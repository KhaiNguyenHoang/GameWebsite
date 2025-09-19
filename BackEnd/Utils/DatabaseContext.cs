using BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Utils
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Permission>? Permissions { get; set; }
        public DbSet<IDCard>? IDCards { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseLazyLoadingProxies() // bật lazy loading
                    .UseSqlServer(
                        "Server=localhost;Database=GameWebsite;User Id=sa;Password=Admin12345!;TrustServerCertificate=True;"
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Account - IDCard (1-1)
            modelBuilder
                .Entity<Account>()
                .HasOne(a => a.IdCard)
                .WithOne(i => i.Account)
                .HasForeignKey<IDCard>(i => i.AccountId);

            // Account - Role (many-to-many)
            modelBuilder
                .Entity<Account>()
                .HasMany(a => a.Roles)
                .WithMany(r => r.Accounts)
                .UsingEntity(j => j.ToTable("AccountRoles"));

            // Account - Permission (many-to-many)
            modelBuilder
                .Entity<Account>()
                .HasMany(a => a.Permissions)
                .WithMany(p => p.Accounts)
                .UsingEntity(j => j.ToTable("AccountPermissions"));
        }
    }
}
