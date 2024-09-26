using System;
using DotNetFundamentals.Core.Entities;
using DotNetFundamentals.Todo.Commands;
using MongoDB.Bson;

namespace DotNetFundamentals.Todo.Services.Mappings;

public static class TodoItemMapper
{
    public static TodoItem MapToTodoItem(this AddTodoCommand source) 
    {
        var dest = new TodoItem();
        
        dest.Id = ObjectId.GenerateNewId().ToString();
        dest.Title = source.Title;
        dest.Description = source.Description;
        dest.OwnerName = source.OwnerName;
        dest.IsCompleted = source.IsCompleted;
        
        return dest;
    }
}
