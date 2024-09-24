using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services;

public static class CoreServiceRegistration
{
     public static IServiceCollection  AddSharedServices(this IServiceCollection services)
    {
        services.AddTransient<RequestLoggingMiddleware>();
        services.AddTransient<RequestTimingMiddleware>();
        services.AddTransient<BlockPathMiddleware>();
        services.AddTransient<ExceptionHandlingMiddleware>();
        return services;
    }
}
