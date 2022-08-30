using System.Collections.Generic;

namespace EfCoreEntityFrameworkCore.Options;

public class UnitOfWorkOptions
{
    public bool Enable { get; set; } = true;

    /// <summary>
    /// 需要忽略的url
    /// </summary>
    public List<string> IgnoredUrl { get; set; } = new();
}