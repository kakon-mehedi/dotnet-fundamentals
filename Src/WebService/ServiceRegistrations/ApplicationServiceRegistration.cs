using DotNetFundamentals.Core.Services;
using DotNetFundamentals.Todo.Services;

namespace DotNetFundamentals.WebService.ServiceRegistrations;


public static class ApplicationServiceRegistration
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddCoreServices(configuration);
        services.AddApplicationServices();
        services.AddApplicationCommandHandlers();
        return services;
    }

    public static IServiceCollection AddApplicationServices(this IServiceCollection services) {
        
        services.AddTodoServices();
        return services;
    }
}