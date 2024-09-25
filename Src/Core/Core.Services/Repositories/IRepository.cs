using System.Linq.Expressions;

namespace DotNetFundamentals.Core.Services.Repositories;

public interface IRepository<TCollectionName> where TCollectionName : class
{
    Task<TCollectionName> GetByIdAsync(string id);
    Task<IEnumerable<TCollectionName>> GetAllAsync();
    Task<IEnumerable<TCollectionName>> GetAllAsync(Expression<Func<TCollectionName, bool>> predicate);
    Task<TResponse> AddAsync<TCommand, TResponse>(TCommand command);
    Task UpdateAsync(string id, TCollectionName entity);
    Task DeleteAsync(string id);
}