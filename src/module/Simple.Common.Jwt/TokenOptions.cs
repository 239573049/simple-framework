namespace Simple.Common.Jwt;

public class TokenOptions
{
    /// <summary>
    /// 密钥
    /// </summary>
    public string SecretKey { get; set; }

    /// <summary>
    /// 发行人
    /// </summary>
    public string Issuer { get; set; }

    /// <summary>
    /// 拥护者
    /// </summary>
    public string Audience { get; set; }

    /// <summary>
    /// 过期时间 (分钟)
    /// </summary>
    public int ExpireMinutes { get; set; }

    /// <summary>
    /// Signalr的url
    /// 如果不设置的话无法在signalr拿到token
    /// </summary>
    public List<string> SignalrUrl { get; set; } = new List<string>();
}