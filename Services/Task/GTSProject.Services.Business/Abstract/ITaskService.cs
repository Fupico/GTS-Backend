using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Dto.TaskDtos;
using Task = GTSProject.Services.Entity.Concrete.Task;

namespace GTSProject.Services.Business.Abstract
{
    public interface ITaskService : IService<Task, CreateTaskDto, UpdateTaskDto, GetByIdTaskDto, ResultTaskDto>
    {
    }
}
