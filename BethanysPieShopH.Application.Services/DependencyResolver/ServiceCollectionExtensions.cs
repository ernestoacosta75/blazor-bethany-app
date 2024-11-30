using BethanysPieShopH.Application.Services.Countries;
using BethanysPieShopH.Application.Services.Employees;
using BethanysPieShopH.Application.Services.Profiles;
using BethanysPieShopH.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Application.Services.Countries;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Application.State;
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
            services.AddScoped<ITimeRegistrationService, TimeRegistrationService>();
            services.AddScoped<ApplicationState>();
        }
    }
}
