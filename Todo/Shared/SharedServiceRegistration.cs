using Todo.Shared.Middlewares;

namespace Todo.Shared;

public static class SharedServiceRegistration
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        services.AddTransient<RequestLoggingMiddleware>();
        services.AddTransient<RequestTimingMiddleware>();
        services.AddTransient<BlockPathMiddleware>();
        services.AddTransient<ExceptionHandlingMiddleware>();
        return services;
    }
}