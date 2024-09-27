using System;
using DotNetFundamentals.Core.Services.Injectors.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services.Injectors;

public static class InjectorServiceRegistration
{
    public static IServiceCollection AddInjectorServices(this IServiceCollection services) {
        services.AddTransient<ICommonValueInjectorService, CommonValueInjectorService>();
        services.AddTransient<IMetadataInjectorService, MetadataInjectorService>();
        
        return services;
    }
 }
