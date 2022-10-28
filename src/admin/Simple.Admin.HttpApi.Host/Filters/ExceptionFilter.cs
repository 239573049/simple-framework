using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using Simple.Admin.HttpApi.Host.Views;

namespace Simple.Admin.HttpApi.Host.Filters;

/// <summary>
/// 全局异常拦截器
/// </summary>
[DebuggerStepThrough] // debug时不进入方法调试
public class ExceptionFilter : ExceptionFilterAttribute
{
    private readonly ILogger<ExceptionFilter> _logger;

    public ExceptionFilter(ILogger<ExceptionFilter> logger)
    {
        _logger = logger;
    }

    public override Task OnExceptionAsync(ExceptionContext context)
    {
        var ex = context.Exception;

        _logger.LogError("Path {Path} message {Exception}", context.HttpContext.Request.Path, context.Exception);

        context.Result = new OkObjectResult(new HttpResult(500, ex.Message));

        context.ExceptionHandled = true;


        return Task.CompletedTask;
    }
}