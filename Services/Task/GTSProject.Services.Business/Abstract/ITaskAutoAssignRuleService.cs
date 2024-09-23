using GTSProject.Services.Core.Results;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Abstract
{
    public interface ITaskAutoAssignRuleService
    {
        IResult Add(TaskAutoAssignRule taskAutoAssignRule);
        IResult Delete(TaskAutoAssignRule taskAutoAssignRule);
        IResult Update(TaskAutoAssignRule taskAutoAssignRule);

        IDataResult<List<TaskAutoAssignRule>> GetAll();
        IDataResult<TaskAutoAssignRule> GetById(int taskAutoAssignRuleId);
    }
}
