using LiteBus.Commands.Abstractions;

using MyShop.Domain.Products;

namespace MyShop.Application.Products.DeleteProduct
{
    internal class DeleteProductCommandHandler(
        IProductRepository productRepository) : ICommandHandler<DeleteProductCommand, int>
    {
        public async Task<int> HandleAsync(DeleteProductCommand command, CancellationToken cancellationToken = default)
        {
            var product = await productRepository.GetByIdAsync(command.ProductId);

            return await productRepository.DeleteAsync(product);
        }
    }
}
