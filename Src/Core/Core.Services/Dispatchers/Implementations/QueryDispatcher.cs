using System;

namespace DotNetFundamentals.Core.Services.Dispatchers.Implementations;

public class QueryDispatcher : IQueryDispatcher
{
    public Task<TResponse> DispatchAsync<TQuery, TResponse>(TQuery? query)
    {
        throw new NotImplementedException();
    }
}
