using LiteBus.Commands.Abstractions;

using MyShop.Domain.Products;

namespace MyShop.Application.Products.UpdateProduct
{
    internal sealed class UpdateProductCommandHandler(
        IProductRepository productRepository) : ICommandHandler<UpdateProductCommand, int>
    {
        public async Task<int> HandleAsync(UpdateProductCommand command, CancellationToken cancellationToken = default)
        {
            var product = await productRepository.GetByIdAsync(command.ProductId);

            product.Update(command.ProductName, command.UnitPrice, command.UnitsInStock);
    
            return await productRepository.CommitAsync();
        }
    }
}
