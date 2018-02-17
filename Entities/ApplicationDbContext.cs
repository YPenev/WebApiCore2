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
            const string databasePass = "dodolica.123";

            return $"Server=localhost;" + // $"Server=91.215.216.110;" +
                   $"database={databaseName};" +
                   $"uid={databaseUser};" +
                   $"pwd={databasePass};" +
                   $"pooling=true;";
        }

        public DbSet<City> Citys { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}