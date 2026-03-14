using LiteBus.Queries.Abstractions;

namespace MyShop.Application.Products.GetProducts
{
    public record GetProductsQueryDto(
        int ProductId,
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock);
}
