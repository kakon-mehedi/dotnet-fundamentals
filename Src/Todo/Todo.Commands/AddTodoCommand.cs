using System;
using DotNetFundamentals.Todo.Services.Models;

namespace DotNetFundamentals.Todo.Commands;

public class AddTodoCommand
{
public Todo Todo { get; set; }

    public AddTodoCommand(Todo todo)
    {
        Todo = todo;
    }
}
