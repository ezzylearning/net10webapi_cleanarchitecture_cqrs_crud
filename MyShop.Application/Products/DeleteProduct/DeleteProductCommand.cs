using LiteBus.Commands.Abstractions;

namespace MyShop.Application.Products.DeleteProduct
{
    public record DeleteProductCommand(int ProductId) : ICommand<int>;
}
