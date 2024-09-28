using System;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;

namespace DotNetFundamentals.Todo.CommandHandlers;

public class DeleteTodoHandler: ICommandHandler<DeleteTodoCommand, ApiResponseModel>
{
    private readonly ITodoService _todoService;

    public DeleteTodoHandler(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public async Task<ApiResponseModel> HandleAsync(DeleteTodoCommand command)
    {
        return await _todoService.DeleteTodoAsync(command);
    }
}
