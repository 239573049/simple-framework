using System.Collections.Generic;

namespace EntityFrameworkCore.Options;

public class UnitOfWorkOptions
{
    /// <summary>
    /// 是否启动自动工作单元
    /// </summary>
    public bool Enable { get; set; } = true;

    /// <summary>
    /// 自动工作单元事务处理忽略的url
    /// </summary>
    public List<string> IgnoredUrl { get; set; } = new();

    /// <summary>
    /// 自定义获取当前人委托
    /// </summary>
    public string? GetIdType { get; set; }

    /// <summary>
    /// 自定义获取当前租户Id委托
    /// </summary>
    public string? GetTenantIdType { get; set; }
}