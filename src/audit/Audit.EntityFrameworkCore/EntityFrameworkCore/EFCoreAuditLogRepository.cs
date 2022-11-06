using audit.Domain.Audit;
using EntityFrameworkCore.Core;

namespace Audit.EntityFrameworkCore.EntityFrameworkCore;

public class EfCoreAuditLogRepository : EfCoreRepository<AuditDbContext, AuditLog>,IAuditLogRepository
{
    public EfCoreAuditLogRepository(AuditDbContext dbContext) : base(dbContext)
    {
    }
}