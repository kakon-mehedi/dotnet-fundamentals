using DotNetFundamentals.Core.Services;
using DotNetFundamentals.Todo.Services;

namespace DotNetFundamentals.WebService;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddTodoServices();
        return services;
    }

    public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSharedServices();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddMongoDbRepositoryServices(configuration);

        return services;
    }
}