namespace DotNetFundamentals.Core.Entities;

public class TodoItem
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string OwnerName { get; set; }
    public bool IsCompleted { get; set; }
}
