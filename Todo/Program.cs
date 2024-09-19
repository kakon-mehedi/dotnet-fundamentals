using Todo;
using Todo.Shared.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCoreServices(builder.Configuration);
builder.Services.RegisterApplicationServices();

var app = builder.Build();

app.AddApplicationMiddleware(app.Environment);
app.MapControllers();

// Simple Todo app using Repository pattern
app.Run();