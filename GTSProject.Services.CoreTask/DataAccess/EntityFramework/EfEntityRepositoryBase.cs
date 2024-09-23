using GTSProject.Services.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace GTSProject.Services.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>(TContext _tContext) : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            var addedEntity = _tContext.Entry(entity);
            addedEntity.State = EntityState.Added;
            _tContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            var deletedEntity = _tContext.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _tContext.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return _tContext.Set<TEntity>().SingleOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _tContext.Set<TEntity>().ToList()
                : _tContext.Set<TEntity>().Where(filter).ToList();
        }

        public void Update(TEntity entity)
        {
            var updatedEntity = _tContext.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            _tContext.SaveChanges();
        }
    }
}
