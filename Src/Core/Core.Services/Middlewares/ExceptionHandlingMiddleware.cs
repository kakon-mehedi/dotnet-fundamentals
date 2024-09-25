using System.Collections.Immutable;
using Microsoft.AspNetCore.Http;

namespace DotNetFundamentals.Core.Services;


public class ExceptionHandlingMiddleware: IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        Console.WriteLine($"Exception: {exception.Message}");

        var errorResponse = new ErrorResponse
        {
            StatusCode = context.Response.StatusCode = 500, // Internal Server Error
            Message = "An unexpected error occurred.",
            DetailedMessage = exception.Message, // Optionally include stack trace for detailed errors
            StackTrace = exception.StackTrace
        };

        context.Response.ContentType = "application/json";
        return context.Response.WriteAsync(System.Text.Json.JsonSerializer.Serialize(errorResponse));
    }
}

public class ErrorResponse
{
    public int StatusCode { get; set; }
    public string Message { get; set; }
    public string DetailedMessage { get; set; } // Optional, you can include stack trace or error details
    public dynamic? StackTrace { get; set; }
}
