using GTSProject.Services.Core.DataAccess;
using GTSProject.Services.Core.Entities;

namespace GTSProject.Services.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity, new();
        Task<int> SaveChangesAsync();
    }
}
