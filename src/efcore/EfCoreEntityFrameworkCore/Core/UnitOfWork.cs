using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Simple.Domain.Base;
using Token.EntityFrameworkCore.Core;

namespace EfCoreEntityFrameworkCore.Core
{
    public class UnitOfWork<TDbContext> : IUnitOfWork<TDbContext> where TDbContext : MasterDbContext
    {
        private readonly TDbContext _dbContext;
        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException($"db context nameof{nameof(dbContext)} is null");
        }

        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            ApplyChangeConventions();
            try
            {
                await _dbContext.SaveChangesAsync(cancellationToken);
                await _dbContext.Database.CommitTransactionAsync(cancellationToken);
            }
            catch (Exception)
            {
                await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
                throw;
            }
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ApplyChangeConventions();
            return await _dbContext.SaveChangesAsync(cancellationToken);
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
            if (entry.Entity is  IHasModificationTime entity)
            {
                entity.LastModificationTime = DateTime.Now;
            }
        }

        private static void SetCreation(EntityEntry entry)
        {
            if (entry.Entity is  IHasCreationTime entity)
            {
                entity.CreationTime = DateTime.Now;
            }
        }

        private static void SetDelete(EntityEntry entry)
        {
            if (entry.Entity is  ISoftDelete entity)
            {
                entity.IsDeleted = true;
            }

        }
    }
}
