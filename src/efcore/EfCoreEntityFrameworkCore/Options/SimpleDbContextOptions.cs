using System.ComponentModel.DataAnnotations;

namespace EfCoreEntityFrameworkCore.Options;

public class SimpleDbContextOptions
{
    public static string Name = "ConnectionStrings";

    /// <summary>
    /// 连接字符串
    /// </summary>
    [Required(ErrorMessage = "连接字符串是必须的")]
    public string Default { get; set; }
}