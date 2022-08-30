using Simple.Domain.Base;

namespace Simple.Common.Jwt;

public interface ICurrentManage
{
    /// <summary>
    /// 获取租户Id
    /// </summary>
    /// <returns></returns>
    Guid? GetTenantId();

    /// <summary>
    /// 是否授权
    /// </summary>
    /// <returns></returns>
    bool? IsAuthenticated();

    /// <summary>
    /// 用户id
    /// </summary>
    /// <returns></returns>
    Guid? UserId();

    /// <summary>
    /// 获取用户信息
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    T? UserInfo<T>();
    
    /// <summary>
    /// 签发token
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    Task<string> CreateTokenAsync<T, TKey>(T data) where T : Entity<TKey>;
}