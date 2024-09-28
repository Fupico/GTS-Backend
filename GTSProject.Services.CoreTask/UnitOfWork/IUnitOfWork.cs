using GTSProject.Services.Core.DataAccess.Abstract;
using GTSProject.Services.Core.Entities;
using GTSProject.Services.Core.Utilities.Results;
using Microsoft.EntityFrameworkCore;

namespace GTSProject.Services.Core.UnitOfWork
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity, new();
        TContext GetContext { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task RollbackAsync();
        Task<DataResult<bool>> CompleteAsync();
        Task LogTransactionAsync(string transactionDetails);
    }
}
