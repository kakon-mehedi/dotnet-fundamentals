namespace DotNetFundamentals.WebService.ServiceRegistrations;

public static class ApplicationBootstrapServices
{
    public static IServiceCollection AddBootstrapServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        return services;
    }
}
