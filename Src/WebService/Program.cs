using DotNetFundamentals.WebService;
using Todo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddBootstrapServices(builder.Configuration);
builder.Services.RegisterApplicationServices();

var app = builder.Build();

app.AddApplicationMiddleware(app.Environment);
app.MapControllers();


app.Run();