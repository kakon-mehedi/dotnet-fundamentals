using System;
using DotNetFundamentals.Core.Services.Dispatchers.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services.Dispatchers;

public static class DispatcherServiceRegistration
{
    public static IServiceCollection AddDispatcherServices(this IServiceCollection services)
    {
        services.AddTransient<ICommandDispatcher, CommandDispatcher>();
        services.AddTransient<IQueryDispatcher, QueryDispatcher>();

        return services;
    }
}
