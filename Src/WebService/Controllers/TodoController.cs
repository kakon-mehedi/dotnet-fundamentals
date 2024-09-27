using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]/[action]")]
[ApiController]
public class TodoController : Controller
{
    private readonly ICommandDispatcher _commandDispatcher;
    private readonly IQueryDispatcher _queryDispatcher;
    
    public TodoController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher)
    {
       _commandDispatcher = commandDispatcher;
       _queryDispatcher = queryDispatcher;
    }

    [HttpPost]
    public async Task<ApiResponseModel> AddTodo([FromBody] AddTodoCommand command)
    {
        ApiResponseModel response = new();
        try
        {
            response.Data =  await _commandDispatcher.DispatchAsync<AddTodoCommand, ApiResponseModel>(command);
        }
        catch (Exception ex)
        {
            throw;
        }

        return response;
    }

    [HttpGet]
    public async Task<ApiResponseModel> GetTodos()
    {
        ApiResponseModel response = new();

        try
        { 
            response.Data = await _queryDispatcher.DispatchAsync<GetAllTodosQuery, ApiResponseModel>();
            
        }
        catch (Exception e)
        {
            throw;
        }

        return response;
    }

}