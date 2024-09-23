using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfTaskProjectDal(TaskServiceContext _context) : EfEntityRepositoryBase<TaskProject, TaskServiceContext>(_context), ITaskProjectDal
    {
    }
}
