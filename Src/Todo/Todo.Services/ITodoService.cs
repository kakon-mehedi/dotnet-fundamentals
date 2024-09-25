
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;

namespace DotnetFundamentals.Todo.Services;


public interface ITodoService
{
    Task<ApiResponse> AddTodoAsync(AddTodoCommand command);
    Task<ApiResponse> UpdateTodoAsync(UpdateTodoCommand command);
    Task<ApiResponse> DeleteTodoAsync(DeleteTodoCommand command);
    Task<ApiResponse> GetTodosAsync();
    Task<ApiResponse> GetTodoByIdAsync(string id);
    
}