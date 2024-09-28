
using DotNetFundamentals.Core.Services.Repositories;
using DotNetFundamentals.Core.Services.Shared.Models;
using DotNetFundamentals.Todo.Commands;
using DotNetFundamentals.Todo.Services.Mappings;
using DotNetFundamentals.Core.Entities.Todo;
using DotNetFundamentals.Core.Services.Injectors;

namespace DotnetFundamentals.Todo.Services.Implementations;

public class TodoService : ITodoService
{
    private readonly IRepository _repositoryService;
    private readonly ICommonValueInjectorService _commonValueInjectorService;

    private readonly IMetadataInjectorService _metadataInjectorService;

    public TodoService(IRepository repository, ICommonValueInjectorService commonValueInjectorService, IMetadataInjectorService metadataInjectorService)
    {
        _repositoryService = repository;
        _commonValueInjectorService = commonValueInjectorService;
        _metadataInjectorService = metadataInjectorService;

    }

    public async Task<ApiResponseModel> AddTodoAsync(AddTodoCommand command)
    {
        ApiResponseModel response = new();
        var todo = command.MapToTodoItem();
        _commonValueInjectorService.Inject<TodoItem>(todo);
        _metadataInjectorService.Inject<TodoItem>(todo);

        try
        {
            await _repositoryService.InsertAsync<TodoItem>(todo);
        }
        catch (Exception e)
        {
            throw;

        }

        return response.SetSuccess(todo);

    }

    public async Task<ApiResponseModel> GetTodosAsync<TodoItem>()
    {
        ApiResponseModel response = new();

        var res = await _repositoryService.GetAllAsync<TodoItem>();
        response.SetData(res);
    
        return response;
    }

    public Task<ApiResponseModel> GetTodoByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponseModel> UpdateTodoAsync(UpdateTodoCommand command)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponseModel> DeleteTodoAsync(DeleteTodoCommand command)
    {
        throw new NotImplementedException();
    }
}