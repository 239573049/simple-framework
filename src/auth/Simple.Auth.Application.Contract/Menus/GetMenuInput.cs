namespace Simple.Auth.Application.Contract.Menus;

/// <summary>
/// 
/// </summary>
public class GetMenuInput
{
    /// <summary>
    /// 关键字
    /// </summary>
    public string? Keywords { get; set; }

    //public static bool TryParse(string? keywords, out GetMenuInput input)
    //{
    //    input = new GetMenuInput();
    //    input.Keywords = keywords;
    //    return true;
    //}
}