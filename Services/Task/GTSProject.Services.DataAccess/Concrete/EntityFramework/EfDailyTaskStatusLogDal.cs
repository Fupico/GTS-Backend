using GTSProject.Services.CoreTask.DataAccess.EntityFramework;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.DataAccess.Concrete.EntityFramework;
using GTSProject.Services.Task.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class EfDailyTaskStatusLogDal(TaskServiceContext _context) : EfEntityRepositoryBase<DailyTaskStatusLog, TaskServiceContext>(_context), IDailyTaskStatusLogDal
    {

    }
}