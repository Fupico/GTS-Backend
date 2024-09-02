using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;
using GTSProject.Services.Task.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfKeywordToTaskReasonDal(TaskServiceContext _context) : EfEntityRepositoryBase<KeywordToTaskReason, TaskServiceContext>(_context), IKeywordToTaskReasonDal
    {
    }
}
