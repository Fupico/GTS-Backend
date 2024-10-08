using AutoMapper;
using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Core.Business.Concrete;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Concrete;
using GTSProject.Services.Dto.TaskDtos;
using Task = GTSProject.Services.Entity.Concrete.Task;

namespace GTSProject.Services.Business.Concrete
{
    public class TaskManager : ServiceBase<Task, CreateTaskDto, UpdateTaskDto, GetByIdTaskDto, ResultTaskDto, TaskServiceContext>, ITaskService
    {
        public TaskManager(IUnitOfWork<TaskServiceContext> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
