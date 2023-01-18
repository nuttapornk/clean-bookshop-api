using Application.Common.Interfaces;
using Domain.Common;
using Infrastructure.Identity;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Interceptors;
using Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Set database Connection string
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("BookShop1"),
                builder => builder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
        });

        // Interface IApplicationDbContext DbContext for Datebase connection
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<AppDbContext>());

        services.AddTransient<IMemoryCache, RedisCacheService>();
        //Set Redis
        var RedisConnectionString = configuration.GetConnectionString("Redis");
        if (!string.IsNullOrEmpty(RedisConnectionString))
        {
            

            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = RedisConnectionString;
                options.InstanceName = configuration.GetValue<string>("RedisSetting:InstanceName");
                //options.ConfigurationOptions = new StackExchange.Redis.ConfigurationOptions()
                //{
                //    DefaultDatabase = configuration.GetValue<int>("RedisSetting:DefaultDatabase"),
                //    ConnectRetry = configuration.GetValue<int>("RedisSetting:ConnectRetry")
                //};
            });                
        }
        
        

        services.AddTransient<IDateTime, DatetimeService>();
        
        return services;
    }
}
