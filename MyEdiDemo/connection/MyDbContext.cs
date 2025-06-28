using Microsoft.EntityFrameworkCore;
using MyEdiDemo.models;

namespace MyEdiDemo.connection
{
    public class MyDbContext : DbContext
    {
        public DbSet<Dessert> Desserts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                "Server=localhost;Database=mitactest;User=root;Password=root;",
                new MySqlServerVersion(new Version(8, 0, 36))
            );
        }
    }
}

