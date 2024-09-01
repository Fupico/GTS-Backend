using GTSProject.Services.CoreTask.DataAccess;
using GTSProject.Services.Task.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Abstract
{
    public interface IDailyTaskStatusLogDal : IEntityRepository<DailyTaskStatusLog>
    {
    }
}
