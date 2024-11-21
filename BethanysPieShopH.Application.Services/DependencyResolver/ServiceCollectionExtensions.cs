using BethanysPieShopH.Application.Services.Countries;
using BethanysPieShopH.Application.Services.Employees;
using BethanysPieShopH.Application.Services.Profiles;
using BethanysPieShopHRM.Application.Services.Countries;
using BethanysPieShopHRM.Application.Services.Employees;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopH.Application.Services.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles));
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICountryService, CountryService>();
        }
    }
}
