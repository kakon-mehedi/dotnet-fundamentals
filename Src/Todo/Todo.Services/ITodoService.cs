
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;

namespace DotnetFundamentals.Todo.Services;


public interface ITodoService
{
    Task<ApiResponseModel> AddTodoAsync(AddTodoCommand command);
    Task<ApiResponseModel> UpdateTodoAsync(UpdateTodoCommand command);
    Task<ApiResponseModel> DeleteTodoAsync(DeleteTodoCommand command);
    Task<ApiResponseModel> GetTodosAsync<TEntity>();
    Task<ApiResponseModel> GetTodoByIdAsync(string id);
    
}