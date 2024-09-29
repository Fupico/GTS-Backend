using GTSProject.Services.Core.Business.Abstract;
using GTSProject.Services.Core.Utilities.Results;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Abstract
{
    public interface ITaskAutoAssignRuleService : IService<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto, UpdateTaskAutoAssignRuleDto, GetByIdTaskAutoAssignRuleDto, ResultTaskAutoAssignRuleDto>
    {
    }
}
