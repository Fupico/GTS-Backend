using GTSProject.Services.Core.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfTaskDal(TaskServiceContext _context) : EfEntityRepositoryBase<Entity.Concrete.Task, TaskServiceContext>(_context), ITaskDal
    {
    }
}
