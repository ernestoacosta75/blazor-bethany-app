using BethanysPieShopHRM.Application.Services.Employees;
using BethanysPieShopHRM.Client;
using BethanysPieShopHRM.Client.Profiles;
using BethanysPieShopHRM.Client.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
    }
);

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IEmployeeService, ClientEmployeeService>();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();

await builder.Build().RunAsync();
