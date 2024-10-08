using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.WebApi;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GTSProject.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAutoAssignRulesController : GenericController<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto, UpdateTaskAutoAssignRuleDto, GetByIdTaskAutoAssignRuleDto, ResultTaskAutoAssignRuleDto>
    {
        public TaskAutoAssignRulesController(IService<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto, UpdateTaskAutoAssignRuleDto, GetByIdTaskAutoAssignRuleDto, ResultTaskAutoAssignRuleDto> taskService) : base(taskService)
        {
        }
    }
}
