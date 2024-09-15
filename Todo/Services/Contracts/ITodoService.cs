using Todo.Models;
using Todo.Shared.Models;

namespace Todo.Services.Contracts;


public interface ITodoService
{
    Task<TodoItem> AddTodoAsync(TodoItem todo);

    Task<IEnumerable<TodoItem>> GetTodosAsync();

    Task<TodoItem> GetTodoByIdAsync(string id);

    Task<TodoItem> UpdateTodoAsync(string id, TodoItem updatedTodo);

    Task<bool> DeleteTodoAsync(string id);
    
}