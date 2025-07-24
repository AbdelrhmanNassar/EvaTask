using Eva.Domain._Entities;
using Eva.Domain.DbContexts;
using Eva.Domain.Repositories.Interfaces;
using Eva.Domain.Repositories.Repo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Eva.Domain
{
    public static class DomainDependencyInjection
    {
        //            Di Container 
        public static IServiceCollection AddDomainLayerDependencies(this IServiceCollection services , IConfiguration configuration )
        {
            services.AddDbContext<CategoryDbContext>((options) =>
            options.UseSqlServer(configuration.GetConnectionString("Eva")));
            services.AddScoped<ICategoryRepository, CategoryRepository>();

            return services; 

        }
    }
}
