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

    public async Task<TodoItem> AddTodoAsync(TodoItem todo)
    {
        ApiResponse response = new ApiResponse();
        
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

        return response.Data;

    }

    public Task<IEnumerable<TodoItem>> GetTodosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TodoItem> GetTodoByIdAsync(string id)
    {
        throw new NotImplementedException();
    }
    
    public Task<TodoItem> UpdateTodoAsync(string id, TodoItem updatedTodo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteTodoAsync(string id)
    {
        throw new NotImplementedException();
    }
}