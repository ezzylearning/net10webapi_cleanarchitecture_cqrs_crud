using LiteBus.Commands.Abstractions;

namespace MyShop.Application.Products.UpdateProduct
{
    public record UpdateProductCommand(
        int ProductId,
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock) : ICommand<int>;
}
