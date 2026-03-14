using LiteBus.Commands.Abstractions;
using LiteBus.Queries.Abstractions;

using Microsoft.AspNetCore.Mvc;

using MyShop.Application.Products.CreateProduct;
using MyShop.Application.Products.DeleteProduct;
using MyShop.Application.Products.GetProduct;
using MyShop.Application.Products.GetProducts;
using MyShop.Application.Products.UpdateProduct;

using System.Threading.Tasks;

namespace MyShop.API.Controllers.Products
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(
        ICommandMediator commandMediator,
        IQueryMediator queryMediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await queryMediator.QueryAsync(new GetProductsQuery());

            return Ok(products);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById([FromRoute] int productId)
        {
            var product = await queryMediator.QueryAsync(new GetProductQuery(productId));
            
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
        {
            var id = await commandMediator.SendAsync(
                new CreateProductCommand(
                    request.ProductName,
                    request.UnitPrice,
                    request.UnitsInStock));

            return Ok(id);
        }

        [HttpPut("{productId}")]
        public async Task<IActionResult> Update(
            [FromRoute] int productId,
            [FromBody] UpdateProductRequest request)
        {
            var id = await commandMediator.SendAsync(
                new UpdateProductCommand(
                    productId,
                    request.ProductName,
                    request.UnitPrice,
                    request.UnitsInStock));

            return Ok(id);
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete([FromRoute] int productId)
        {
            var id = await commandMediator.SendAsync(
                new DeleteProductCommand(
                    productId));

            return Ok(id);
        }
    }
}
