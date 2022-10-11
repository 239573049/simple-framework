﻿using System;
using EntityFrameworkCore.Mysql.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Simple.Auth.EntityFrameworkCore;
using Simple.EntityFrameworkCore;
using Token.Module;
using Token.Module.Attributes;

namespace EntityFrameworkCore.DbMigrations;

[DependOn(typeof(SimpleEntityFrameworkCoreModule),
    typeof(SimpleAuthEntityFrameworkCoreModule))]
public class EntityFrameworkCoreDbMigrationsModule : TokenModule
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddMysqlEfCoreEntityFrameworkCore<EfCoreMigrationDbContext>(new Version(8,0,10));
    }
}