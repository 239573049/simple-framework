using audit.Domain.Audit;
using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Audit.EntityFrameworkCore.EntityFrameworkCore;

public class AuditDbContext : MasterDbContext<AuditDbContext>
{

    public DbSet<AuditLog> AuditLogs { get; set; } = null!;

    public AuditDbContext(DbContextOptions<AuditDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

    }
}