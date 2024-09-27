using System;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services.Middlewares;

public static class MiddlewareServiceRegistration
{
    public static IServiceCollection AddMiddlewareServices(this IServiceCollection services)
    {
        services.AddTransient<RequestLoggingMiddleware>();
        services.AddTransient<RequestTimingMiddleware>();
        services.AddTransient<BlockPathMiddleware>();
        services.AddTransient<ExceptionHandlingMiddleware>();
        return services;
    }
}
