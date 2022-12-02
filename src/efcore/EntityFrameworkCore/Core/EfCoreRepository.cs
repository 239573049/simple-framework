﻿using Microsoft.EntityFrameworkCore;
using Simple.Shared.Base;
using System.Linq.Expressions;
using Token.Dependency;

namespace EntityFrameworkCore.Core;

/// <summary>
/// 通用仓储实现
/// </summary>
/// <typeparam name="TDbContext"></typeparam>
/// <typeparam name="TEntity"></typeparam>
/// <typeparam name="TKey"></typeparam>
public abstract class EfCoreRepository<TDbContext, TEntity, TKey> : EfCoreRepository<TDbContext, TEntity>,
    IRepository<TEntity, TKey>
    where TEntity : Entity<TKey>
    where TDbContext : DbContext
{
    protected EfCoreRepository(TDbContext dbContext) : base(dbContext)
    {
    }

    public async Task DeleteAsync(TKey id, CancellationToken cancellationToken = default)
    {
        var entity = await DbSet.FirstOrDefaultAsync(x => x.Id!.Equals(id), cancellationToken: cancellationToken);
        if (entity != null)
        {
            DbSet.Remove(entity);
        }
    }

    public async Task DeleteManyAsync(IEnumerable<TKey> ids, CancellationToken cancellationToken = default)
    {
        var entity = await DbSet.Where(x => ids.Contains(x.Id)).ToListAsync(cancellationToken: cancellationToken);

        if (entity.Count > 0)
        {
            DbSet.RemoveRange(entity);
        }
    }

}

public abstract class EfCoreRepository<TDbContext, TEntity> : IRepository<TEntity>, ITransientDependency
    where TEntity : class
    where TDbContext : DbContext
{
    protected readonly TDbContext DbContext;
    protected readonly DbSet<TEntity> DbSet;

    protected EfCoreRepository(TDbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = dbContext.Set<TEntity>();
    }

    public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await DbSet.FirstOrDefaultAsync(predicate, cancellationToken: cancellationToken);
    }

    public async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await DbSet.FirstAsync(predicate, cancellationToken: cancellationToken);
    }

    public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await DbSet.Where(predicate).ToListAsync(cancellationToken);
    }

    public async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate,
        CancellationToken cancellationToken = default)
    {
        return await DbSet.CountAsync(predicate, cancellationToken) > 0;
    }

    public async Task<IQueryable<TEntity>> GetQueryAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await Task.FromResult(DbSet.Where(predicate));
    }

    public async Task<IQueryable<TResult>> GetQueryAsync<TResult>(Expression<Func<TEntity, bool>> predicate,
        Expression<Func<TEntity, TResult>> selector)
    {
        return await Task.FromResult(DbSet.Where(predicate).Select(selector));
    }

    public async Task<TEntity> InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        return (await DbSet.AddAsync(entity, cancellationToken)).Entity;
    }

    public async Task InsertManyAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        await DbSet.AddRangeAsync(entities, cancellationToken);
    }

    public Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        DbSet.Remove(entity);
        return Task.CompletedTask;
    }

    public Task DeleteManyAsync(IEnumerable<TEntity> entity, CancellationToken cancellationToken = default)
    {
        DbSet.RemoveRange(entity);
        return Task.CompletedTask;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        DbSet.Update(entity);
        return await Task.FromResult(entity);
    }

    public Task UpdateManyAsync(IEnumerable<TEntity> entities)
    {
        DbSet.UpdateRange(entities);

        return Task.CompletedTask;
    }
}
