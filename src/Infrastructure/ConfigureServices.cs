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

        //Set Redis       
        ConfigRedis(services, configuration);
       

        services.AddTransient<IDateTime, DatetimeService>();

        //
       
        return services;
    }

    private static void ConfigRedis(IServiceCollection services, IConfiguration configuration)
    {
        var RedisConnectionString = configuration.GetConnectionString("Redis");
        if (!string.IsNullOrEmpty(RedisConnectionString))
        {
            services.AddTransient<IMemoryCache, RedisCacheService>();
            services.Configure<RedisCacheSetting>(configuration.GetSection("RedisSetting"));

            RedisCacheSetting setting = new();
            configuration.GetSection("RedisSetting").Bind(setting);
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = RedisConnectionString;
                options.InstanceName = setting.InstanceName;

                options.ConfigurationOptions = new StackExchange.Redis.ConfigurationOptions
                {
                    EndPoints = { { setting.EndPointHost, setting.EndPointPort } },                    
                    Ssl = setting.Ssl,
                    DefaultDatabase = setting.DefaultDatabase,
                    ConnectRetry = setting.ConnectRetry                   
                };

                //options.ConfigurationOptions.DefaultDatabase = setting.DefaultDatabase;
                //options.ConfigurationOptions.ConnectRetry = setting.ConnectRetry;                
            });
        }
    }

}
