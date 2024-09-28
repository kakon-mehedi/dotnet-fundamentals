using DotNetFundamentals.Core.Services.Repositories;
using DotNetFundamentals.Core.Services.Repositories.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace DotNetFundamentals.Core.Services;

public static class RepositoryServiceRegistration
{
    
    public static IServiceCollection AddMongoDbRepositoryServices(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoDbConnectionString = configuration["DatabaseInfo:MongoDbConnectionString"];
        var mongoClient = new MongoClient(mongoDbConnectionString);

        var database = mongoClient.GetDatabase(configuration["DatabaseInfo:DatabaseName"]);

        services.AddSingleton<IMongoDatabase>(database);
        //services.AddScoped(typeof(IRepository<>), typeof(MongoRepository<>)); // For generic repo purpose
        
        services.AddScoped(typeof(IRepository), typeof(MongoRepository));

        return services;
    }

}