using System;
using Amazon.SecurityToken.Model;

namespace DotNetFundamentals.Core.Services.Auth;

public interface IAuthData
{
    string UserName { get; }

    string UserEmail { get;}
    
    string UserId   { get; }

    string UserDetailedInfo { get; }

}
