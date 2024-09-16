namespace Todo.Shared.Middlewares;

public class RequestLoggingMiddleware: IMiddleware
{
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        Console.WriteLine($"Request: {context.Request.Path}");
        
        await next(context);
        
        Console.WriteLine($"Response Status Code: {context.Response.StatusCode}");
    }
}