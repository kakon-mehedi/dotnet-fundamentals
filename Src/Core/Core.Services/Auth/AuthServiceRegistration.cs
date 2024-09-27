using System;
using DotNetFundamentals.Core.Services.Auth.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetFundamentals.Core.Services.Auth;

public static class AuthServiceRegistration
{
    public static IServiceCollection AddAuthServices(this IServiceCollection services){
        services.AddTransient<IAuthService, AuthService>();

        return services;
    }
}
