using Microsoft.EntityFrameworkCore;

using MyShop.Domain.Products;

namespace MyShop.Infrastructure
{
    public class MyShopDbContext(DbContextOptions<MyShopDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
    }
}
