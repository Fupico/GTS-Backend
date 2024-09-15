using GTSProject.Services.Core.DataAccess;
using GTSProject.Services.Entity.Concrete;
using GTSProject.Services.Task.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Abstract
{
    public interface IKeywordToTaskReasonDal : IEntityRepository<KeywordToTaskReason>
    {
    }
}
