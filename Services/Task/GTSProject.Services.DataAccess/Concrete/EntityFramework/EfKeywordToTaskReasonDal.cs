using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfKeywordToTaskReasonDal(TaskServiceContext _context) : EfEntityRepositoryBase<KeywordToTaskReason, TaskServiceContext>(_context), IKeywordToTaskReasonDal
    {
    }
}
