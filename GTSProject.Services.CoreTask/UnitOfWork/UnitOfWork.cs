using GTSProject.Services.Core.DataAccess.Abstract;
using GTSProject.Services.Core.Entities;
using GTSProject.Services.Core.Utilities.Results;
using GTSProject.Services.Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.Core.UnitOfWork
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext, new()
    {
        private readonly TContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(TContext context, IDbContextTransaction transaction = null)
        {
            _context = context;
            _transaction = transaction;
        }

        public IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity, new()
        {
            return new EfEntityRepositoryBase<TEntity, TContext>(_context, this);
        }

        public TContext GetContext => _context;

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public async Task<DataResult<bool>> CompleteAsync()
        {
            try
            {
                UpdateAuditableEntities();
                await _context.SaveChangesAsync();
                return new DataResult<bool>(true, true);
            }
            catch (Exception ex)
            {
                return new DataResult<bool>(false, false, ex.Message);
            }
        }

        private void UpdateAuditableEntities()
        {
            var now = DateTime.Now;
            var userId = Guid.NewGuid();

            foreach (var entry in _context.ChangeTracker.Entries<BaseEntity>())
            {
                if (entry.Entity == null) continue;

                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = now;
                        entry.Entity.CreatedBy = userId;
                        entry.Entity.IsActive = true;
                        entry.Entity.IsDeleted = false;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateDate = now;
                        entry.Entity.UpdateBy = userId;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.DeleteDate = now;
                        entry.Entity.DeleteBy = userId;
                        entry.Entity.IsActive = false;
                        entry.Entity.IsDeleted = true;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
        }

        public async Task LogTransactionAsync(string transactionDetails)
        {
            // İşlemin detaylarını loglar (örneğin dosyaya yazma veya başka bir logging sistemi)
            await File.AppendAllTextAsync("transaction_log.txt", transactionDetails + Environment.NewLine);
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}
