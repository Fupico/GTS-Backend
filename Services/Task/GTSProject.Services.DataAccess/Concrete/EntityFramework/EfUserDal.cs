using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, TaskServiceContext>, IUserDal
    {
        private readonly TaskServiceContext _context;
        private readonly IUnitOfWork<TaskServiceContext> _unitOfWork;

        public EfUserDal(TaskServiceContext context, IUnitOfWork<TaskServiceContext> unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
    }
}
