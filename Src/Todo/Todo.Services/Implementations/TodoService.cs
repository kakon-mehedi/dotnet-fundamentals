
using DotNetFundamentals.Core.Services.Repositories;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Services.Models;

namespace DotnetFundamentals.Todo.Services.Implementations;

public class TodoService: ITodoService
{
    private readonly IRepository<TodoModel> _respositoryService;
    
    public TodoService(IRepository<TodoModel> repository)
    {
        _respositoryService = repository;
    }

    public async Task<ApiResponse<TodoModel>> AddTodoAsync(TodoModel todo)
    {
        ApiResponse<TodoModel> response = new();
        
        try
        {
            var res = await _respositoryService.AddAsync(todo);
            response.Data = res;
        }
        catch (Exception e)
        {
            response.IsSuccess = false;
            response.Message = e.Message;

        }

        response.IsSuccess = true;
        response.Message = "success";

        return response;

    }
    
    public async Task<ApiResponse<List<TodoModel>>> GetTodosAsync()
    {
        ApiResponse<List<TodoModel>> response = new ();

        try
        {
            var res = await  _respositoryService.GetAllAsync();
            response.Data = res.ToList();
            response.IsSuccess = true;
        }
        catch (Exception e)
        {
            response.IsSuccess = false;
            response.Data = null;
        }

        return response;
    }

    public Task<ApiResponse<TodoModel>> GetTodoByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
    
    public Task<ApiResponse<TodoModel>> UpdateTodoAsync(string id, TodoModel updatedTodo)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<bool>> DeleteTodoAsync(string id)
    {
        throw new NotImplementedException();
    }
}