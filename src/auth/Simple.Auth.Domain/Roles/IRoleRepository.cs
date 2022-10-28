using EntityFrameworkCore.Shared.Base;
using System;

namespace Simple.Auth.Domain.Roles
{

    public interface IRoleRepository : IRepository<Role, Guid>
    {

    }
}