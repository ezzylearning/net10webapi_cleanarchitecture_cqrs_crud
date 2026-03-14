using LiteBus.Queries.Abstractions;

namespace MyShop.Application.Products.GetProduct
{
    public record GetProductQueryDto(
        int ProductId,
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock);
}
