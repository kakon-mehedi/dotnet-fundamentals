using Todo.Services.Contracts;
using Todo.Services.Implementations;

namespace Todo.Services;

public static class TodoServiceCollectionRegistration
{
    public static IServiceCollection AddTodoServices(this IServiceCollection services)
    {
        services.AddTransient<ITodoService, TodoService>();
        return services;
    }
}