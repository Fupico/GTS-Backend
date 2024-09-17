using GTSProject.Services.Core.DataAccess;
using GTSProject.Services.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Abstract
{
    public interface ITaskStatusDal : IEntityRepository<Entity.Concrete.TaskStatus>
    {
    }
}


