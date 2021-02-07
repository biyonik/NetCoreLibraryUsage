using Microsoft.EntityFrameworkCore;
using NetCoreLibraryUsage.FluentValidation.WebUI.Models;

namespace NetCoreLibraryUsage.FluentValidation.WebUI.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NOOAEV8\\SQLEXPRESS;Database=LibraryUsageDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
    }
}