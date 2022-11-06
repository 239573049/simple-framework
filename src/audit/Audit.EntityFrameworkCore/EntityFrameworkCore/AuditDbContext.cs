﻿using EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Audit.EntityFrameworkCore.EntityFrameworkCore;

public class AuditDbContext : MasterDbContext<AuditDbContext>
{
    public AuditDbContext(DbContextOptions<AuditDbContext> options) : base(options)
    {
    }


}