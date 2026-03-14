using LiteBus.Commands.Abstractions;

namespace MyShop.Application.Products.CreateProduct
{
    public record CreateProductCommand(
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock) : ICommand<int>;
}
