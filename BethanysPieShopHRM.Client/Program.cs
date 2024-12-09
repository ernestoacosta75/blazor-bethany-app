using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Client.Profiles;
using BethanysPieShopHRM.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    }
);

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddScoped<IEmployeeService, ClientEmployeeService>();

await builder.Build().RunAsync();
