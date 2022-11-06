using Simple.Shared.Base;

namespace audit.Domain.Audit;

public class AuditLog : Entity<Guid>
{
    public string ApplicationName { get; set; }

    public Guid? UserId { get; protected set; }

    public string UserName { get; protected set; }

    public DateTime ExecutionTime { get; protected set; }

    public string ClientIpAddress { get; protected set; }

    public string BrowserInfo { get; protected set; }

    public string HttpMethod { get; protected set; }

    public string Url { get; protected set; }

    public string? Exceptions { get; protected set; }

    public string? Comments { get; protected set; }

    public int? HttpStatusCode { get; set; }

    protected AuditLog()
    {

    }

    public void SetId(Guid id)
    {
        Id = id;
    }

    public AuditLog(Guid id, string applicationName, Guid? userId, string userName, DateTime executionTime, string clientIpAddress, string browserInfo, string httpMethod, string url, string? exceptions, string? comments, int? httpStatusCode) : base(id)
    {
        ApplicationName = applicationName;
        UserId = userId;
        UserName = userName;
        ExecutionTime = executionTime;
        ClientIpAddress = clientIpAddress;
        BrowserInfo = browserInfo;
        HttpMethod = httpMethod;
        Url = url;
        Exceptions = exceptions;
        Comments = comments;
        HttpStatusCode = httpStatusCode;
    }
    
}
