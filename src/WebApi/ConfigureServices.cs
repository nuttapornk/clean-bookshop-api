using Domain.Common;

namespace WebApi;

public static class ConfigureServices
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpContextAccessor();
        services.Configure<AppSetting>(configuration.GetSection("AppSetting"));
     
        return services;
    }
}
