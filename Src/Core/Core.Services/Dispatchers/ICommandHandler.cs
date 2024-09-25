using System;
using Amazon.Runtime;

namespace DotNetFundamentals.Core.Services.Dispatchers;

public interface ICommandHandler<TCommand, TResponse>
{
    
    Task<TResponse> HandleAsync(TCommand command);

}
