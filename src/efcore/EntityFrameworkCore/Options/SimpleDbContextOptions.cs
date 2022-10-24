using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Options;

public class SimpleDbContextOptions
{
    public static string Name = "ConnectionStrings";

    /// <summary>
    /// 连接字符串
    /// </summary>
    [Required(ErrorMessage = "连接字符串是必须的")]
    public string Default { get; set; } = null!;

    /// <summary>
    /// 是否启用软删过滤器
    /// </summary>
    public bool SoftDelete { get; set; } = true;

    /// <summary>
    /// 是否启用租户
    /// </summary>
    public bool Tenant { get; set; }
}