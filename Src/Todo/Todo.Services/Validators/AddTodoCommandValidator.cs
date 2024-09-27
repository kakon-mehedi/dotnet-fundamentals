using System;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Core.Services.Validators;
using DotNetFundamentals.Todo.Commands;

namespace DotNetFundamentals.Todo.Services.Validators;

public class AddTodoCommandValidator : IValidator<AddTodoCommand>
{
    public ApiResponseModel Validate(AddTodoCommand model)
    {
        var response = new ApiResponseModel();

        if (string.IsNullOrWhiteSpace(model.Title)) response.SetError("0", "Title can not be empty");
        if (string.IsNullOrWhiteSpace(model.Description)) response.SetError("0", "Description can not be empty");
        if (string.IsNullOrWhiteSpace(model.OwnerName)) response.SetError("0", "OwnerName can not be empty");
        if (model.IsCompleted) response.SetError("0", "Completed can not be true initially");

        return response;
    }

    public async Task<ApiResponseModel> ValidateAsync(AddTodoCommand model)
    {
        return await Task.Run(() => Validate(model));
    }
}
