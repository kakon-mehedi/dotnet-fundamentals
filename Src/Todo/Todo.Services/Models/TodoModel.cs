using System;

namespace DotNetFundamentals.Todo.Services.Models;

public class TodoModel
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}
