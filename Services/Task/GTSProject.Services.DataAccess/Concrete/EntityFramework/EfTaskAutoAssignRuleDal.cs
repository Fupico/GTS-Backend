using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfTaskAutoAssignRuleDal(TaskServiceContext _context) : EfEntityRepositoryBase<TaskAutoAssignRule, TaskServiceContext>(_context), ITaskAutoAssignRuleDal
    {
    }
}
