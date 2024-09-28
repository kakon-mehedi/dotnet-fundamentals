using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DotnetFundamentals.Todo.Services;
using DotNetFundamentals.Core.Services.Dispatchers;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Core.Services.Validators;
using DotNetFundamentals.Todo.Commands;
using DotNetFundamentals.Todo.Services.Validators;

namespace DotNetFundamentals.Todo.CommandHandlers;

public class AddTodoCommandHandler : ICommandHandler<AddTodoCommand, ApiResponseModel>
{
    private readonly ITodoService _todoService;

    public AddTodoCommandHandler(ITodoService todoService)
    {
        _todoService = todoService;
    }

    public async Task<ApiResponseModel> HandleAsync(AddTodoCommand command)
    {
        IValidator<AddTodoCommand> validator = new AddTodoCommandValidator();

        var response = await validator.ValidateAsync(command);

        if (response.IsSuccess)
        {
            response = await _todoService.AddTodoAsync(command);
        }

        response.SetStatusCode(response.IsSuccess ? 200 : 400);

        return response;
    }
}
