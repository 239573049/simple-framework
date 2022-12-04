using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using EntityFrameworkCore.Extensions;

namespace Simple.AuditLog.Extensions;

public static class SimpleAuditLogExtension
{
    public static void ConfigSimpleAuditLog(this ModelBuilder builder)
    {
        builder.Entity<SimpleAuditLog>(simple =>
        {
            simple.AddSimpleConfigure();

            simple.HasIndex(x => x.AppServerName);
        });
    }
}