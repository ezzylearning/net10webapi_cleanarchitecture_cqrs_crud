using LiteBus.Queries.Abstractions;

namespace MyShop.Application.Products.GetProduct
{
    public record GetProductQuery(int ProductId) : IQuery<GetProductQueryDto>;
}
