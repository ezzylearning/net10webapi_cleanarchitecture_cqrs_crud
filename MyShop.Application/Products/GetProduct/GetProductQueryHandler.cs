using LiteBus.Queries.Abstractions;

using MyShop.Domain.Products;

namespace MyShop.Application.Products.GetProduct
{
    internal sealed class GetProductQueryHandler(
        IProductRepository productRepository) : IQueryHandler<GetProductQuery, GetProductQueryDto>
    {
        public async Task<GetProductQueryDto> HandleAsync(GetProductQuery command, CancellationToken cancellationToken = default)
        {
            var product = await productRepository.GetByIdAsync(command.ProductId);
                
            return new GetProductQueryDto(
                product.ProductId,
                product.ProductName,
                product.UnitPrice,
                product.UnitsInStock);
        }
    }
}
