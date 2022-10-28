using System;
using Simple.Shared.Base;

namespace Simple.Auth.Domain.Users
{
    public interface IAuthUserInfoRepository : IRepository<AuthUserInfo, Guid>
    {

    }
}