using System;
using DotNetFundamentals.Core.Entities;

namespace DotNetFundamentals.Core.Services.Injectors;

public interface ICommonValueInjectorService
{
    TEntity Inject<TEntity>(TEntity model) where TEntity : EntityBase;
    List<TEntity> Inject<TEntity>(List<TEntity> entities) where TEntity : EntityBase;
    TEntity InjectFromExisting<TEntity>(TEntity model, TEntity source) where TEntity : EntityBase;
}
