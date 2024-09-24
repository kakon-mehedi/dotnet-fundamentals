
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Services.Models;

namespace DotnetFundamentals.Todo.Services;


public interface ITodoService
{
    Task<ApiResponse<TodoModel>> AddTodoAsync(TodoModel todo);

    Task<ApiResponse<List<TodoModel>>> GetTodosAsync();

    Task<ApiResponse<TodoModel>> GetTodoByIdAsync(string id);

    Task<ApiResponse<TodoModel>> UpdateTodoAsync(string id, TodoModel updatedTodo);

    Task<ApiResponse<bool>> DeleteTodoAsync(string id);
    
}