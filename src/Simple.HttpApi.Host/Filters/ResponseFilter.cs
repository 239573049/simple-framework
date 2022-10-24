using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Simple.HttpApi.Host.Views;
using System.Diagnostics;

namespace Simple.HttpApi.Host.Filters;

/// <summary>
/// 全局过滤器
/// </summary>
[DebuggerStepThrough] // debug时不进入方法调试
public class ResponseFilter : ActionFilterAttribute
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Result != null)
        {
            if (context.Result is ObjectResult)
            {
                ObjectResult? objectResult = context.Result as ObjectResult;
                if (objectResult?.Value?.GetType().Name == nameof(HttpResult))
                {
                    var result = objectResult.Value as HttpResult;

                    context.Result = new ObjectResult(result);
                }
                else
                {
                    context.Result = new ObjectResult(new HttpResult(200, data: objectResult?.Value));
                }
            }
            else if (context.Result is EmptyResult)
            {
                context.Result = new ObjectResult(new HttpResult(200));
            }
            else if (context.Result is HttpResult modelStateResult2)
            {
                context.Result = new ObjectResult(modelStateResult2);
            }
        }
        else
        {
            context.Result = new ObjectResult(new HttpResult(200));
        }


        base.OnActionExecuted(context);
    }
}