using System.Reflection;
using DotNetFundamentals.Core.Services;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Todo.CommandHandlers;
using DotNetFundamentals.Todo.Services;

namespace DotNetFundamentals.WebService;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddTodoServices();
        services.AddApplicationCommandHandlers();
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

    public static IServiceCollection AddApplicationCommandHandlers(this IServiceCollection services)
    {

        var assembliesToScan = new[]
        {
                typeof(AddTodoCommandHandler).Assembly,  // As we are selecting the assembly here. so This will add Todo.CommandHandler projects all command handlers.
                   
            };

        var handlerTypes = assembliesToScan
            .SelectMany(assembly => assembly.GetTypes())
            .Where(t => t.GetInterfaces().Any(i => i.IsGenericType &&
                (i.GetGenericTypeDefinition() == typeof(ICommandHandler<,>) ||
                i.GetGenericTypeDefinition() == typeof(IQueryHandler<,>))))
            .ToList();

        foreach (var handlerType in handlerTypes)
        {
            var interfaceType = handlerType.GetInterfaces().First(i => i.IsGenericType);
            services.AddScoped(interfaceType, handlerType);
        }

        return services;
    }

}