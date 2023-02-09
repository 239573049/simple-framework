using EntityFrameworkCore.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;
using Simple.Shared.Base;
using System;
using System.Linq;
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
        private readonly IServiceProvider _serviceProvider;
        private readonly UnitOfWorkOptions _unitOfWorkOptions;

        public UnitOfWork(TDbContext dbContext, IServiceProvider serviceProvider, IOptions<UnitOfWorkOptions> unitOfWorkOptions)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException($"db context nameof{nameof(dbContext)} is null");
            _serviceProvider = serviceProvider;
            _unitOfWorkOptions = unitOfWorkOptions.Value;
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
            
            // TODO: 如果未存在修改实体不进行事务提交
            if (!_dbContext.ChangeTracker.Entries().Any())
            {
                return;
            }
            ApplyChangeConventions();
            try
            {
                // 使用EntityFrameworkCore的事务提交
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

                    modificationAuditedObject.LastModifierId = GetUserId();
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
                creator.CreatorId = GetUserId();
            }

            switch (entry.Entity)
            {
                case IHasCreationTime creationTime:
                    creationTime.CreationTime = DateTime.Now;
                    break;
            }

            if (entry.Entity is ITenant tenant)
            {
                tenant.TenantId = GetTenantId();
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
            deleteCreator.DeleteCreatorId = GetUserId();

        }

        public Guid? GetUserId()
        {
            try
            {

                var httpContext = _serviceProvider.GetService(typeof(HttpContext)) as HttpContext;
                var value = httpContext?.User?.Claims?.FirstOrDefault(x => x.Type == _unitOfWorkOptions.GetIdType)
                    ?.Value;
                if (string.IsNullOrEmpty(value))
                    return null;

                return Guid.Parse(value);
            }
            catch
            {
                return null;
            }
        }

        public Guid? GetTenantId()
        {
            try
            {

                var httpContext = _serviceProvider.GetService(typeof(HttpContext)) as HttpContext;
                var value = httpContext?.User?.Claims?.FirstOrDefault(x => x.Type == _unitOfWorkOptions.GetTenantIdType)
                    ?.Value;
                if (string.IsNullOrEmpty(value))
                    return null;

                return Guid.Parse(value);
            }
            catch
            {
                return null;
            }
        }

        public void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            IsDisposed = true;
        }

    }
}