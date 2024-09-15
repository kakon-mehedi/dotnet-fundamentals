using MongoDB.Driver;
using Todo.Repositories.Contracts;
using Todo.Repositories.Implementations;

namespace Todo.Repositories;

public static class RepositoryServiceRegistration
{
    public static IServiceCollection AddMongoDbRepositoryServices(this IServiceCollection services, IConfiguration configuration)
    {
        var mongoDbConnectionString = configuration["DatabaseInfo:MongoDbConnectionString"];
        var mongoClient = new MongoClient(mongoDbConnectionString);
            
        var database = mongoClient.GetDatabase(configuration["DatabaseInfo:DatabaseName"]);
            
        services.AddSingleton<IMongoDatabase>(database);
        services.AddScoped(typeof(IRepository<>), typeof(MongoRepository<>));
        
        return services;
    }
    
}