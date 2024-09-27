using System;
using DotNetFundamentals.Core.Services.Shared.Models;

namespace DotNetFundamentals.Core.Services.Validators;

public interface IValidator<TCommandOrQuery>
{
    ApiResponseModel Validate(TCommandOrQuery model);
    Task<ApiResponseModel> ValidateAsync(TCommandOrQuery model);
}
