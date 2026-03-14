using LiteBus.Commands.Abstractions;

using MyShop.Domain.Products;

namespace MyShop.Application.Products.CreateProduct
{
    internal sealed class CreateProductCommandHandler(
        IProductRepository productRepository) : ICommandHandler<CreateProductCommand, int>
    {
        public async Task<int> HandleAsync(CreateProductCommand command, CancellationToken cancellationToken = default)
        {
            var product = Product.Create(
                command.ProductName,
                command.UnitPrice,
                command.UnitsInStock);

            await productRepository.AddAsync(product);
            return await productRepository.CommitAsync();
        }
    }
}
