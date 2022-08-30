using EfCoreEntityFrameworkCore.Core;
using Simple.Domain.Users;
using Token.EntityFrameworkCore.Core;

namespace Simple.EntityFrameworkCore;

public class EfCoreUserInfoRepository : Repository<SimpleDbContext, UserInfo, Guid>, IUserInfoRepository
{
    private readonly IUnitOfWork<SimpleDbContext> _unitOfWork;
    public EfCoreUserInfoRepository(SimpleDbContext dbContext, IUnitOfWork<SimpleDbContext> unitOfWork) : base(dbContext)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UserInfo> CreateAsync(UserInfo userInfo)
    {
        var result =  await _dbSet.AddAsync(userInfo);
        await _unitOfWork.SaveChangesAsync();

        return result.Entity;
    }
}