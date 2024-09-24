using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Services.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;

[Route("api/[controller]/[action]")]
[ApiController]
public class TodoController : Controller
{
    private readonly ITodoService _todoService; 
    
    public TodoController(ITodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpPost]
    public async Task<ApiResponse<TodoModel>> AddTodo([FromBody] TodoModel todo)
    {
        ApiResponse<TodoModel> response = new();
        try
        {
            if (string.IsNullOrEmpty(todo.Id))
            {
                todo.Id = ObjectId.GenerateNewId().ToString();
            }
            response = await _todoService.AddTodoAsync(todo);
           
        }
        catch (Exception e)
        {
            response.IsSuccess = false;
            response.Data = null;
            response.StatusCode = 500;
        }

        return response;

    }

    [HttpGet]
    public async Task<ApiResponse<List<TodoModel>>> GetTodos()
    {
        ApiResponse<List<TodoModel>> response = new();

        try
        { 
            response = await _todoService.GetTodosAsync();
            
        }
        catch (Exception e)
        {
            response.Data = null;
            response.IsSuccess = false;
            throw;
        }

        return response;
    }

}