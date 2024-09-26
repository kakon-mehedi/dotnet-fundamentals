using System;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Entities;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;

namespace DotNetFundamentals.Todo.QueryHandlers;

public class GetAllTodosQueryHandler : IQueryHandler<GetAllTodosQuery, ApiResponse>
{
    private readonly ITodoService _service;
    public GetAllTodosQueryHandler(ITodoService todoService)
    {
        _service = todoService;
    }

    public Task<ApiResponse> HandleAsync(GetAllTodosQuery? query)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse> HandleAsync()
    {
       return await  _service.GetTodosAsync<TodoItem>();
    }
}
