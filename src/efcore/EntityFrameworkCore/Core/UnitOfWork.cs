using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Simple.Common.Jwt;
using Simple.Domain.Base;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Core
{
    public sealed class UnitOfWork<TDbContext> : IUnitOfWork, IDisposable where TDbContext : DbContext
    {
        public bool IsDisposed { get; private set; }

        public bool IsRollback { get; private set; }
        public bool IsCompleted { get; private set; }

        private readonly TDbContext _dbContext;
        private readonly CurrentManage _currentManage;
        private readonly TenantManager _tenantManager;
        public UnitOfWork(TDbContext dbContext, CurrentManage currentManage, TenantManager tenantManager)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException($"db context nameof{nameof(dbContext)} is null");
            _currentManage = currentManage;
            _tenantManager = tenantManager;
        }

        public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            IsCompleted = false;
            await _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (IsCompleted)
            {
                return;
            }

            IsCompleted = true;
            ApplyChangeConventions();
            try
            {
                // 提交事务
                await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                await _dbContext.Database.CommitTransactionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                // 发生异常回滚事务
                await RollbackTransactionAsync(cancellationToken).ConfigureAwait(false);
                throw;
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            if (IsCompleted)
            {
                return;
            }
            IsRollback = true;
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken).ConfigureAwait(false);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyChangeConventions();
            return await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        }

        private void ApplyChangeConventions()
        {
            _dbContext.ChangeTracker.DetectChanges();
            foreach (var entry in _dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Deleted:
                        SetDelete(entry);
                        break;
                    case EntityState.Modified:
                        SetModified(entry);
                        break;
                    case EntityState.Added:
                        SetCreation(entry);
                        break;
                }
            }
        }

        private void SetModified(EntityEntry entry)
        {
            switch (entry.Entity)
            {
                case IModificationAuditedObject modificationAuditedObject:
                    modificationAuditedObject.LastModifierId = _currentManage.UserId();
                    modificationAuditedObject.LastModificationTime = DateTime.Now;
                    break;
                case IHasModificationTime entity:
                    entity.LastModificationTime = DateTime.Now;
                    break;
            }
        }

        private void SetCreation(EntityEntry entry)
        {
            if (entry.Entity is IMayHaveCreator creator)
            {
                creator.CreatorId = _currentManage.UserId();
            }

            switch (entry.Entity)
            {
                case IHasCreationTime creationTime:
                    creationTime.CreationTime = DateTime.Now;
                    break;
            }

            if (entry.Entity is ITenant tenant)
            {
                tenant.TenantId = _tenantManager.GetTenantId();
            }
        }

        private void SetDelete(EntityEntry entry)
        {
            if (entry.Entity is ISoftDelete entity)
            {
                entity.IsDeleted = true;
            }

            if (entry.Entity is not IHasDeleteCreator deleteCreator) return;

            deleteCreator.DeleteTime = DateTime.Now;
            deleteCreator.DeleteCreatorId = _currentManage.UserId();

        }


        public void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            IsDisposed = true; throw new NotImplementedException();
        }

    }
}