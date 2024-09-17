using GTSProject.Services.Core.DataAccess;
using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Concrete;


namespace GTSProject.Services.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TaskServiceContext _context;
        private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

        public UnitOfWork(TaskServiceContext context)
        {
            _context = context;
        }

        IEntityRepository<TEntity> IUnitOfWork.GetRepository<TEntity>()
        {
            if (_repositories.ContainsKey(typeof(TEntity)))
            {
                return (IEntityRepository<TEntity>)_repositories[typeof(TEntity)];
            }

            var repository = new EfEntityRepositoryBase<TEntity, TaskServiceContext>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
