using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfTaskResponsibleDal : EfEntityRepositoryBase<TaskResponsible, TaskServiceContext>, ITaskResponsibleDal
    {
        private readonly TaskServiceContext _context;
        private readonly IUnitOfWork<TaskServiceContext> _unitOfWork;

        public EfTaskResponsibleDal(TaskServiceContext context, IUnitOfWork<TaskServiceContext> unitOfWork) : base(context, unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }
    }
}
