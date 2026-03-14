using Microsoft.EntityFrameworkCore;

using MyShop.Domain.Products;

namespace MyShop.Infrastructure.Domain.Products
{
    public class ProductRepository(
        MyShopDbContext dbContext) : IProductRepository
    {
        public async Task AddAsync(Product product)
        {
            await dbContext.AddAsync(product);
        }

        public async Task<Product> GetByIdAsync(int productId)
        {
            return await dbContext.Products.FindAsync(productId);
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await dbContext.Products.ToListAsync();
        }

        public async Task<int> DeleteAsync(Product product)
        {
            // Mark the entity for deletion (synchronous operation)
            dbContext.Products.Remove(product);

            // Asynchronously save changes to the database
            return await CommitAsync();
        }

        public async Task<int> CommitAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
