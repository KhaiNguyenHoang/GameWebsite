namespace BackEnd.Utils
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class DatabaseContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<Permission>? Permissions { get; set; }
        public DbSet<IDCard>? IDCards { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=GameWebsite;User Id=sa;Password=Admin12345!; TrustServerCertificate= True;"
            );
        }
    }
}
