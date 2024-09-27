using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Middlewares;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services;

public static class CoreServiceRegistration
{
     public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDispatcherServices();
        services.AddMiddlewareServices();
        services.AddMongoDbRepositoryServices(configuration);
        
        return services;
    }
}
