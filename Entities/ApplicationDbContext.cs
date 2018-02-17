using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebApiJwt.Models.DB;

namespace WebApiJwt.Entities
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(GetConnectionString());
        }

        private static string GetConnectionString()
        {
            const string databaseName = "webapijwt1";
            const string databaseUser = "root"; // "ypenev_dd.123_rm";
            const string databasePass = "root.123";

            return $"Server=localhost;" + // $"Server=91.215.216.110;" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<City>()
                   .HasMany(c => c.Schools)
                   .WithOne(e => e.City);

            builder.Entity<Event>()
                .HasMany(c => c.Tickets)
                .WithOne(e => e.Event);

            builder.Entity<School>()
            .HasMany(c => c.Events)
            .WithOne(e => e.School);

            base.OnModelCreating(builder);
        }

        public DbSet<City> Citys { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}