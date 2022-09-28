using Microsoft.EntityFrameworkCore;
using Project_Blazor.Models;

namespace Project_Blazor.DBContext
{
    public class ProductDB : DbContext
    {
        public virtual DbSet<Product>? Products { get; set; }
        public virtual DbSet<Customer>? Customers { get; set; }
        public virtual DbSet<Order>? Orders { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<SubCategory>? SubCategories  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= DESKTOP-209KG6L ;Database=Project_Blazor_iTi;Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.Entity<Order>().HasKey(w => new { w.Idd_prod, w.Idd_cust });
        }
    }
}
