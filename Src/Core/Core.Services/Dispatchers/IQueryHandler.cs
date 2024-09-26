using System;

namespace DotNetFundamentals.Core.Services.Dispatchers;

public interface IQueryHandler<TQuery, TResponse>
{
    Task<TResponse> HandleAsync(TQuery? query);
    Task<TResponse> HandleAsync();
}
