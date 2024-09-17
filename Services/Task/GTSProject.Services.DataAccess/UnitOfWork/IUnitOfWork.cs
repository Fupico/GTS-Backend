using GTSProject.Services.Core.DataAccess;
using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEntityRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity, new();
        Task<int> SaveChangesAsync();
    }
}
