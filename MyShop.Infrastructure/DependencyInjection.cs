using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyShop.Domain.Products;
using MyShop.Infrastructure.Domain.Products;

namespace MyShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MyShop");

            services.AddDbContext<MyShopDbContext>((sp, options) =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
