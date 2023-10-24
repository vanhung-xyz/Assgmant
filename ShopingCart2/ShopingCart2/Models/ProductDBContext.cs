using Microsoft.EntityFrameworkCore;

namespace ShopingCart2.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-2E2LMDO7\\MSSQLSERVER02;Initial Catalog=Shopping;Persist Security Info=True;User ID=sa;Password=123456;Encrypt=False");
        }

        public DbSet<Product> Products { get; set; }
       
    }
}
