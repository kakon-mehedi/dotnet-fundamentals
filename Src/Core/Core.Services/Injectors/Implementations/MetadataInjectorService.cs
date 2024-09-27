using System;
using DotNetFundamentals.Core.Entities;
using DotNetFundamentals.Core.Services.Auth;
using DotNetFundamentals.Core.Services.Constants;

namespace DotNetFundamentals.Core.Services.Injectors.Implementations;

public class MetadataInjectorService : IMetadataInjectorService
{
    private readonly IAuthService _authService;
    public MetadataInjectorService(IAuthService authService)
    {
        _authService = authService;
    }

    public TEntity Inject<TEntity>(TEntity model) where TEntity : EntityBase
    {
        model.RolesAllowedToRead = _authService.GetAllowedRolesToWrite();
        return model;
    }
}
