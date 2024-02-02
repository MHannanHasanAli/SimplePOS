using Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DataContext : IdentityDbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SimplePOS-DB;Trusted_Connection=true;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
    }
}
