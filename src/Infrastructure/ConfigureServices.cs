using Application.Common.Interfaces;
using Infrastructure.Persistence;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<BookShop1Context>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("BookShop1"),
                builder => builder.MigrationsAssembly(typeof(BookShop1Context).Assembly.FullName));
        });

        services.AddTransient<IDateTime, DatetimeService>();
        return services;
    }
}
