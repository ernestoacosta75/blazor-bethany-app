using BethanysPieShopH.Application.Services.Cache;
using BethanysPieShopH.Application.Services.Countries;
using BethanysPieShopH.Application.Services.Employees;
using BethanysPieShopH.Application.Services.JobCategories;
using BethanysPieShopH.Application.Services.Profiles;
using BethanysPieShopH.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Application.Services.Cache;
using BethanysPieShopHRM.Application.Services.Countries;
using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Application.Services.JobCategories;
using BethanysPieShopHRM.Application.Services.TimeRegistrations;
using BethanysPieShopHRM.Application.State;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BethanysPieShopH.Application.Services.DependencyResolver
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddAutoMapper(typeof(AutoMapperProfiles));
            services.AddScoped<ICacheService, InMemoryCacheService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IJobCategoryService, JobCategoryService>();
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<ITimeRegistrationService, TimeRegistrationService>();
            services.AddScoped<ApplicationState>();
            
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
