using System;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Entities.Todo;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;

namespace DotNetFundamentals.Todo.QueryHandlers;

public class GetAllTodosQueryHandler : IQueryHandler<GetAllTodosQuery, ApiResponseModel>
{
    private readonly ITodoService _service;
    public GetAllTodosQueryHandler(ITodoService todoService)
    {
        _service = todoService;
    }

    public Task<ApiResponseModel> HandleAsync(GetAllTodosQuery? query)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponseModel> HandleAsync()
    {
       return await  _service.GetTodosAsync<TodoItem>();
    }
}
