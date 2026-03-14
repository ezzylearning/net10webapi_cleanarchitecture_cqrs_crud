using LiteBus.Queries.Abstractions;

using MyShop.Domain.Products;

namespace MyShop.Application.Products.GetProducts
{
    internal sealed class GetProductsQueryHandler(
        IProductRepository productRepository) : IQueryHandler<GetProductsQuery, List<GetProductsQueryDto>>
    {
        public async Task<List<GetProductsQueryDto>> HandleAsync(GetProductsQuery message, CancellationToken cancellationToken = default)
        {
            var products = await productRepository.GetProductsAsync();
                
            return products.Select(p => 
                new GetProductsQueryDto(
                    p.ProductId,
                    p.ProductName,
                    p.UnitPrice,
                    p.UnitsInStock
                )).ToList();
        }
    }
}
