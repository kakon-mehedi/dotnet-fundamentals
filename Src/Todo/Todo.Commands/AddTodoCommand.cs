namespace DotNetFundamentals.Todo.Commands;

public class AddTodoCommand
{
  
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public string OwnerName { get; set; } = string.Empty;
    
    public bool IsCompleted { get; set; } = false;
}
