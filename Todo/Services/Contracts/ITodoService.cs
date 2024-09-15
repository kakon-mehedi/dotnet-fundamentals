using Todo.Models;
using Todo.Shared.Models;

namespace Todo.Services.Contracts;


public interface ITodoService
{
    Task<ApiResponse<TodoItem>> AddTodoAsync(TodoItem todo);

    Task<ApiResponse<List<TodoItem>>> GetTodosAsync();

    Task<ApiResponse<TodoItem>> GetTodoByIdAsync(string id);

    Task<ApiResponse<TodoItem>> UpdateTodoAsync(string id, TodoItem updatedTodo);

    Task<ApiResponse<bool>> DeleteTodoAsync(string id);
    
}