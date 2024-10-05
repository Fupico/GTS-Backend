using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.WebApi;
using GTSProject.Services.Dto.TaskDtos;
using Microsoft.AspNetCore.Mvc;
using Task = GTSProject.Services.Entity.Concrete.Task;

[Route("api/[controller]")]
[ApiController]
public class TasksController : GenericController<Task, CreateTaskDto, UpdateTaskDto, GetByIdTaskDto, ResultTaskDto>
{
    public TasksController(IService<Task, CreateTaskDto, UpdateTaskDto, GetByIdTaskDto, ResultTaskDto> taskService) : base(taskService)
    {
    }
}