using BethanysPieShopHTM.Core.DomainServices.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BethanysPieShopHTM.Core.DomainServices.DependencyResolver
{
    public static class ServiceCollectionExtension
    {
        public static void AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            string? connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("No connection string found in configuration.");
            }

            // Using AddDbContextFactory because in the Blazor scenario,
            // whenever the components are using the interactive server mode, AddDbContext isn't ideal.
            // The reason is that the database contex would then be shared across components across the circuit,
            // which can cause problems.
            services.AddDbContextFactory<AppDbContext>(options =>
                    options
                        .ConfigureWarnings(warnings =>
                            warnings.Ignore(RelationalEventId.PendingModelChangesWarning))
                        .UseSqlServer(connectionString, sqlServer =>
                        {
                            sqlServer.UseNetTopologySuite();
                        })
                        .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Warning),
                ServiceLifetime.Scoped);
        }
    }
}
