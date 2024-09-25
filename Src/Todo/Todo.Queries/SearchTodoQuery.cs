using System;

namespace Todo.Queries;

public class SearchTodoQuery
{
    public string QueryParams { get; set; }

    public SearchTodoQuery(string queryParams)
    {
        QueryParams = queryParams;
    }
}
