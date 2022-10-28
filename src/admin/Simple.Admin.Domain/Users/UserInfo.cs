using Simple.Admin.Domain.Shared;
using Simple.Domain.Shared;
using Simple.Shared.Base;

namespace Simple.Admin.Domain.Users;

public class UserInfo : AggregateRoot<Guid>, IUserInfo<Guid>, ITenant
{
    /// <summary>
    /// 昵称
    /// </summary>
    public string? Name { get;  set; }

    /// <summary>
    /// 账号
    /// </summary>
    public string? UserName { get;  set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? PassWord { get;  set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string? Avatar { get;  set; }

    /// <summary>
    /// 账号状态
    /// </summary>
    public UserInfoStatus Status { get;  set; }

    protected UserInfo()
    {
    }



    public UserInfo(Guid id, string? name, string? userName, string? passWord, string? avatar, UserInfoStatus status) : base(id)
    {
        Name = name;
        UserName = userName;
        PassWord = passWord;
        Avatar = avatar;
        Status = status;
    }

    public UserInfo(Guid id, DateTime creationTime, DateTime? lastModificationTime, Guid? lastModifierId, bool isDeleted, Guid? creatorId, string? name, string? userName, string? passWord, string? avatar, UserInfoStatus status) : base(id, creationTime, lastModificationTime, lastModifierId, isDeleted, creatorId)
    {
        Name = name;
        UserName = userName;
        PassWord = passWord;
        Avatar = avatar;
        Status = status;
    }

    public Guid? TenantId { get; set; }
}