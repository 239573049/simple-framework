using EntityFrameworkCore.Core;
using Microsoft.EntityFrameworkCore;
using Simple.Auth.Domain.Users;
using Token.Attributes;

namespace Simple.Auth.EntityFrameworkCore.EntityFrameworkCore.Users;

[ExposeServices(typeof(IAuthUserInfoRepository))]
public class EfCoreAuthUserInfoRepository : EfCoreRepository<AuthDbContext, AuthUserInfo, Guid>, IAuthUserInfoRepository
{
    public EfCoreAuthUserInfoRepository(AuthDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<AuthUserInfoView?> GetAuthUserInfoAsync(string username, string password)
    {
        var userInfo = await DbSet
            .Where(x => x.UserName == username && x.PassWord == password)
            .Select(x => new AuthUserInfoView(x.Id)
            {
                Avatar = x.Avatar,
                Name = x.Name,
                PassWord = x.PassWord,
                Status = x.Status,
                TenantId = x.TenantId,
                UserName = x.UserName
            })
            .FirstOrDefaultAsync();
        if (userInfo == null)
        {
            return default;
        }

        var roles =
            from userRoleFunction in DbContext.UserRoleFunction
            join role in DbContext.Role on userRoleFunction.RoleId equals role.Id
            where userRoleFunction.UserId == userInfo.Id
            select role;

        userInfo.Roles = await roles.ToListAsync();

        return userInfo;
    }
}