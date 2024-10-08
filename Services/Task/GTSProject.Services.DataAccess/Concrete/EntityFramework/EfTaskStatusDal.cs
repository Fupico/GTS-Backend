using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;
using TaskStatus = GTSProject.Services.Entity.Concrete.TaskStatus;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfTaskStatusDal : EfEntityRepositoryBase<TaskStatus, TaskServiceContext>, ITaskStatusDal
    {
        private readonly TaskServiceContext _context;
        private readonly IUnitOfWork<TaskServiceContext> _unitOfWork;

        public EfTaskStatusDal(TaskServiceContext context, IUnitOfWork<TaskServiceContext> unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
    }
}
