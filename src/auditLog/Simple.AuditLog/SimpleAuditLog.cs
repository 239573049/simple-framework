using Simple.Shared.Base;

namespace Simple.AuditLog;

public class SimpleAuditLog : AggregateRoot<Guid>
{
    /// <summary>
    /// 服务名称
    /// </summary>
    public string AppServerName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Path { get; set; }

    public string Query { get; set; }

    public Guid? UserId { get; set; }

    public int Code { get; set; }

    public string Message { get; set; }
    
    
}