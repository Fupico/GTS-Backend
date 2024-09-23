using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Business.Constants;
using GTSProject.Services.Core.Results;
using GTSProject.Services.DataAccess.Abstract;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Concrete
{
    public class TaskAutoAssignRuleManager : ITaskAutoAssignRuleService
    {
        ITaskAutoAssignRuleDal _taskAutoAssignRuleDal;

        public TaskAutoAssignRuleManager(ITaskAutoAssignRuleDal taskAutoAssignRuleDal)
        {
            _taskAutoAssignRuleDal = taskAutoAssignRuleDal;
        }

        public IResult Add(TaskAutoAssignRule taskAutoAssignRule)
        {
            _taskAutoAssignRuleDal.Add(taskAutoAssignRule);
            return new SuccessResult(Messages.TaskAutoAssignRuleAdded);
        }

        public IResult Delete(TaskAutoAssignRule taskAutoAssignRule)
        {
            _taskAutoAssignRuleDal.Delete(taskAutoAssignRule);
            return new SuccessResult(Messages.TaskAutoAssignRuleDeleted);
        }

        public IDataResult<List<TaskAutoAssignRule>> GetAll()
        {
            return new SuccessDataResult<List<TaskAutoAssignRule>>(_taskAutoAssignRuleDal.GetAll(), Messages.TaskAutoAssignRuleListed);
        }

        public IDataResult<TaskAutoAssignRule> GetById(int taskAutoAssignRuleId)
        {
            return new SuccessDataResult<TaskAutoAssignRule>(_taskAutoAssignRuleDal.Get(x => x.Id == taskAutoAssignRuleId), Messages.TaskAutoAssignRuleListed);
        }

        public IResult Update(TaskAutoAssignRule taskAutoAssignRule)
        {
            _taskAutoAssignRuleDal.Update(taskAutoAssignRule);
            return new SuccessResult(Messages.TaskAutoAssignRuleUpdated);
        }
    }
}
