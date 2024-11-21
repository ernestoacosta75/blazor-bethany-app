using BethanysPieShopHRM.Infrastructure.Repositories;
using BethanysPieShopHTM.Core.DomainServices.DependencyResolver;
using BethanysPieShopHTM.Core.DomainServices.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopHRM.Infrastructure.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseContext(configuration);

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
