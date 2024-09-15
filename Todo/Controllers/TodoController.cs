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
    public async Task<IActionResult> AddTodo([FromBody] TodoItem todo)
    {
        ApiResponse resonse = new ApiResponse();
        try
        {
            if (string.IsNullOrEmpty(todo.Id))
            {
                todo.Id = ObjectId.GenerateNewId().ToString();
            }
            var todoAdded = await _todoService.AddTodoAsync(todo);
            resonse.Data = todoAdded;
        }
        catch (Exception e)
        {
            resonse.IsSuccess = false;
        }

        return Ok((resonse));

    }

}