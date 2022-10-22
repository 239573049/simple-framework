using Microsoft.AspNetCore.Mvc;

namespace Simple.Auth.HttpApi.Host.Views;

public class HttpResult : ActionResult
{
    /// <summary>
    /// 异常状态码
    /// </summary>
    public int Code { get; protected set; }

    /// <summary>
    /// 异常信息
    /// </summary>
    public string? Message { get; protected set; }

    /// <summary>
    /// 有效数据
    /// </summary>
    public object? Data { get; protected set; }
    

    public HttpResult(int code = 400, string? message = null, object? data = null)
    {
        Code = code;
        Message = message;
        Data = data;
    }

    public HttpResult()
    {
    }
}