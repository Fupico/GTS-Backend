using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfDailyTaskStatusLogDal(TaskServiceContext _context) : EfEntityRepositoryBase<DailyTaskStatusLog, TaskServiceContext>(_context), IDailyTaskStatusLogDal
    {

    }
}