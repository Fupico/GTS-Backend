using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTSProject.Services.DataAccess.Concrete.EntityFramework
{
    public class TaskServiceContext : DbContext
    {
        protected TaskServiceContext(DbContextOptions<TaskServiceContext> dbContextOptions) : base(dbContextOptions)
        {
        }
    }
}
