using System;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;

namespace DotNetFundamentals.Todo.CommandHandlers;

public class UpdateTodoHandler: ICommandHandler<UpdateTodoCommand, ApiResponse>
{
    private readonly ITodoService _todoService;

    public UpdateTodoHandler(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public async Task<ApiResponse> HandleAsync(UpdateTodoCommand command)
    {
       return await _todoService.UpdateTodoAsync(command);
    }
}
