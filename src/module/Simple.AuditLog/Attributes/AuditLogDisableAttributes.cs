namespace Simple.AuditLog.Attributes;

public class AuditLogDisableAttributes
{
    public readonly bool Disable;

    public AuditLogDisableAttributes(bool disable = true)
    {
        Disable = disable;
    }
}