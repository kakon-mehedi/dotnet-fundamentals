
using DotNetFundamentals.Core.Services.Repositories;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Core.Entities;
using DotNetFundamentals.Todo.Commands;
using DotNetFundamentals.Todo.Services.Mappings;

namespace DotnetFundamentals.Todo.Services.Implementations;

public class TodoService: ITodoService
{
    private readonly IRepository _repositoryService;
    
    public TodoService(IRepository repository)
    {
        _repositoryService = repository;
    }

    public async Task<ApiResponse> AddTodoAsync(AddTodoCommand command)
    {
        ApiResponse response = new();
        
        try
        {
            var todo = command.MapToTodoItem();
            await _repositoryService.InsertAsync<TodoItem>(todo);
        }
        catch (Exception e)
        {
            throw;

        }

        response.IsSuccess = true;
        response.Message = "success";

        return response;

    }
    
    public async Task<ApiResponse> GetTodosAsync<TodoItem>()
    {
        ApiResponse response = new ();

        try
        {
            var res = await  _repositoryService.GetAllAsync<TodoItem>();
            response.Data = res;
            response.IsSuccess = true;
        }
        catch (Exception e)
        {
            response.IsSuccess = false;
            response.Data = null;
        }

        return response;
    }

    public Task<ApiResponse> GetTodoByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
    
    public Task<ApiResponse> UpdateTodoAsync(UpdateTodoCommand command)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse> DeleteTodoAsync(DeleteTodoCommand command)
    {
        throw new NotImplementedException();
    }
}