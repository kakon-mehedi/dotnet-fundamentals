using DotnetFundamentals.Todo.Services;
using DotnetFundamentals.Todo.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;


namespace DotNetFundamentals.Todo.Services;

public static class TodoServiceCollectionRegistration
{
    public static IServiceCollection AddTodoServices(this IServiceCollection services)
    {
        services.AddTransient<ITodoService, TodoService>();
        return services;
    }
}