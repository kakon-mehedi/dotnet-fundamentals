using System;
using DotNetFundamentals.Core.Entities;

namespace DotNetFundamentals.Core.Services.Injectors;

public interface IMetadataInjectorService
{
    TEntity Inject<TEntity>(TEntity model) where TEntity : EntityBase;
}
