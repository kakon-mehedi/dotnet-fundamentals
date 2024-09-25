using System;

namespace Todo.Queries;

public class GetTodoByIdQuery
{
    public string Id { get; set; }

    public GetTodoByIdQuery(string id)
    {
        Id = id;
    }
}
