using Microsoft.AspNetCore.Mvc;
using Todo.Models;
using Todo.Repositories.Contracts;
using Todo.Services.Contracts;
using Todo.Shared.Models;

namespace Todo.Services.Implementations;

public class TodoService: ITodoService
{
    private readonly IRepository<TodoItem> _respositoryService;
    
    public TodoService(IRepository<TodoItem> repository)
    {
        _respositoryService = repository;
    }

    public async Task<ApiResponse<TodoItem>> AddTodoAsync(TodoItem todo)
    {
        ApiResponse<TodoItem> response = new();
        
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
    
    public async Task<ApiResponse<List<TodoItem>>> GetTodosAsync()
    {
        ApiResponse<List<TodoItem>> response = new ();

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

    public Task<ApiResponse<TodoItem>> GetTodoByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
    
    public Task<ApiResponse<TodoItem>> UpdateTodoAsync(string id, TodoItem updatedTodo)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<bool>> DeleteTodoAsync(string id)
    {
        throw new NotImplementedException();
    }
}