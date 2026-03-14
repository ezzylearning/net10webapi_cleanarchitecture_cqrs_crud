namespace MyShop.Domain.Products
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);

        Task<int> DeleteAsync(Product product);

        Task<int> CommitAsync();

        Task<Product> GetByIdAsync(int productId);

        Task<List<Product>> GetProductsAsync();
    }
}
