using System.ComponentModel.DataAnnotations;

namespace Simple.Auth.Application.Contract.Roles;

public class CreateRoleDto
{
    /// <summary>
    /// 角色名称
    /// </summary>
    [Required(ErrorMessage = "角色名称是必须的")]
    public string? Name { get; set; }

    /// <summary>
    /// 角色编号
    /// </summary>
    [Required(ErrorMessage = "角色编号是必须的")]
    public string? Code { get; set; }

    /// <summary>
    /// 索引
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// 是否私有 私有无法删除
    /// </summary>
    public bool IsPrivate { get; set; }
}