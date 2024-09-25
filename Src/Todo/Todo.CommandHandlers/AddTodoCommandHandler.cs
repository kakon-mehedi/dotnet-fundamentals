using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;

namespace DotNetFundamentals.Todo.CommandHandlers;

public class AddTodoCommandHandler : ICommandHandler<AddTodoCommand, ApiResponse>
{
    private readonly ITodoService _todoService;

    public AddTodoCommandHandler(ITodoService todoService)
    {
       _todoService =  todoService;
    }

    public async Task<ApiResponse> HandleAsync(AddTodoCommand command)
    {
        return await _todoService.AddTodoAsync(command);
    }
}
