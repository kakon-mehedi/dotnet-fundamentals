using System;

namespace DotNetFundamentals.Core.Services.Auth;

public interface IAuthService
{
    IAuthData GetCurrentUserData();

    string[] GetAllowedRolesToWrite();
}
