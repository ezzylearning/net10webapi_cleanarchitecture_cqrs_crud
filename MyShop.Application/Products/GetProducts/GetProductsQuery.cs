using LiteBus.Queries.Abstractions;

namespace MyShop.Application.Products.GetProducts
{
    public record GetProductsQuery : IQuery<List<GetProductsQueryDto>>;
}
