namespace Simple.Auth.Application.Contract.Roles;

public class GetRoleInput
{
    /// <summary>
    /// 关键字
    /// </summary>
    public string? Keywords { get; set; }

    public static bool TryParse(string input, out GetRoleInput result)
    {
        result = new GetRoleInput();
        result.Keywords = input;
        return true;
    }
}