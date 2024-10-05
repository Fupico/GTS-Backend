using AutoMapper;
using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Core.Business.Concrete;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.DataAccess.Concrete;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Concrete
{
    public class TaskAutoAssignRuleManager : ServiceBase<TaskAutoAssignRule, CreateTaskAutoAssignRuleDto, UpdateTaskAutoAssignRuleDto, GetByIdTaskAutoAssignRuleDto, ResultTaskAutoAssignRuleDto, TaskServiceContext>, ITaskAutoAssignRuleService
    {
        public TaskAutoAssignRuleManager(IUnitOfWork<TaskServiceContext> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
