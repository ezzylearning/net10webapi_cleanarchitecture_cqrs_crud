namespace MyShop.API.Controllers.Products
{
    public record UpdateProductRequest(
        string ProductName,
        decimal UnitPrice,
        short UnitsInStock);
}
