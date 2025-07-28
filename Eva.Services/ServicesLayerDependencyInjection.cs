using Eva.Services.CategoryServices.Services;
using Eva.Services.CategoryServices.Services.Interfaces;
using Eva.Services.ProductServices;
using Eva.Services.ProductServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Eva.Services
{
    public static class ServicesLayerDependencyInjection
    {

        public static IServiceCollection AddServicesLayerDependencies(this IServiceCollection services)
        {
          
            services.AddScoped<ICategoryServices, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            return services;

        }
    }
}
