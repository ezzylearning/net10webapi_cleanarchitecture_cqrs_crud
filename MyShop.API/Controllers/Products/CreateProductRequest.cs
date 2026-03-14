namespace MyShop.API.Controllers.Products
{
    public record CreateProductRequest(
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock);
}
