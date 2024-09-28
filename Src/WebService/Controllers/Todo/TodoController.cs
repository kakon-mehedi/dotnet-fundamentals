using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFundamentals.WebService.Controllers;

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
        var res = await _commandDispatcher.DispatchAsync<AddTodoCommand, ApiResponseModel>(command);

        if (!res.IsSuccess) {
            HttpContext.Response.StatusCode = res.HttpStatusCode;
        }

        return res;
    }

    [HttpGet]
    public async Task<ApiResponseModel> GetTodos()
    {
        var res = await _queryDispatcher.DispatchAsync<GetAllTodosQuery, ApiResponseModel>();

        if (!res.IsSuccess) {
            HttpContext.Response.StatusCode = res.HttpStatusCode;
        }

        return res;
    }
}
