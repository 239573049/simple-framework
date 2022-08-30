using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Simple.Domain.Base;

namespace EfCoreEntityFrameworkCore.Core
{
    public sealed class UnitOfWork<TDbContext> : IUnitOfWork where TDbContext : MasterDbContext, IDisposable
    {
        public bool IsDisposed { get; private set; }

        public bool IsCompleted { get; private set; }

        private readonly TDbContext _dbContext;

        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException($"db context nameof{nameof(dbContext)} is null");
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            IsCompleted = false;
            return await _dbContext.Database.BeginTransactionAsync(cancellationToken);
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
                await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
                await _dbContext.Database.CommitTransactionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                await _dbContext.Database.RollbackTransactionAsync(cancellationToken).ConfigureAwait(false);
                throw;
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
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
                    default:
                        break;
                }
            }
        }

        private static void SetModified(EntityEntry entry)
        {
            if (entry.Entity is IHasModificationTime entity)
            {
                entity.LastModificationTime = DateTime.Now;
            }
        }

        private static void SetCreation(EntityEntry entry)
        {
            if (entry.Entity is IHasCreationTime entity)
            {
                entity.CreationTime = DateTime.Now;
            }
        }

        private static void SetDelete(EntityEntry entry)
        {
            if (entry.Entity is ISoftDelete entity)
            {
                entity.IsDeleted = true;
            }
        }

        public void Disponse()
        {
            if (this.IsDisposed)
            {
                return;
            }

            this.IsDisposed = true;
        }
    }
}