using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Todo.Models;
using Todo.Services.Contracts;
using Todo.Shared.Models;

namespace Todo.Controllers;

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
    public async Task<ApiResponse<TodoItem>> AddTodo([FromBody] TodoItem todo)
    {
        ApiResponse<TodoItem> response = new();
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
    public async Task<ApiResponse<List<TodoItem>>> GetTodos()
    {
        ApiResponse<List<TodoItem>> response = new();

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