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
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An error occurred!");
            Console.WriteLine($"Exception: {ex.Message}");
        }
    }
}