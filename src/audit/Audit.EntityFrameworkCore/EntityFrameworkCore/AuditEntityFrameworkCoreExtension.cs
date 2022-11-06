using audit.Domain.Audit;
using Microsoft.EntityFrameworkCore;


namespace Audit.EntityFrameworkCore.EntityFrameworkCore;

public static class AuditEntityFrameworkCoreExtension
{
    public static void ConfigureAudit(this ModelBuilder builder)
    {
        builder.Entity<AuditLog>(x =>
        {
            x.ToTable("AuditLogs");

            x.HasIndex(x => x.Id);
            x.HasKey(x => x.Id);

            x.HasIndex(x => x.Url);
        });
    }
}