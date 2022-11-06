using audit.Domain.Audit;
using Audit.Application.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Audit.Application;

public class AuditMiddleware : IMiddleware
{
    private readonly IAuditLogRepository _auditLogRepository;
       
    public AuditMiddleware(IAuditLogRepository auditLogRepository)
    {
        _auditLogRepository = auditLogRepository;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var auditOption = context.RequestServices.GetService<IOptions<AuditOption>>()?.Value;

        var audit = new AuditLog(Guid.NewGuid(),auditOption?.ApplicationName ?? nameof(AuditMiddleware), null, string.Empty,
            DateTime.Now, context.Connection.LocalIpAddress.MapToIPv4().ToString(),
            context.Request.Headers.FirstOrDefault(x => x.Key == "sec-ch-ua-platform").Value.ToString(),
            context.Request.Method, context.Request.QueryString.Value, null, null,null);

        await _auditLogRepository.InsertAsync(audit);

        await next.Invoke(context);

        audit.SetId(Guid.NewGuid()); 
        audit.HttpStatusCode = context.Response.StatusCode;

        await _auditLogRepository.InsertAsync(audit);
    }
}