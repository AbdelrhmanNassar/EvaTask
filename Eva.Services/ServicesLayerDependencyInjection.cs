using Eva.Services.CategoryServices;
using Eva.Services.CategoryServices.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Services
{
    public static class ServicesLayerDependencyInjection
    {

        public static IServiceCollection AddServicesLayerDependencies(this IServiceCollection services)
        {
          
            services.AddScoped<ICategoryServices, CategoryService>();

            return services;

        }
    }
}
