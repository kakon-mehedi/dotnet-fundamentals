using Todo;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCoreServices(builder.Configuration);
builder.Services.RegisterApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();