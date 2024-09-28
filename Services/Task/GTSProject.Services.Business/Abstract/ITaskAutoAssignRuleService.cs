using GTSProject.Services.Core.Utilities.Results;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Abstract
{
    public interface ITaskAutoAssignRuleService
    {
        Task<IResult> AddAsync(CreateTaskAutoAssignRuleDto createTaskAutoAssignRuleDto);
        Task<IResult> DeleteAsync(int taskAutoAssignRuleId);
        Task<IResult> UpdateAsync(UpdateTaskAutoAssignRuleDto updateTaskAutoAssignRuleDto);

        Task<IDataResult<List<ResultTaskAutoAssignRuleDto>>> GetAllAsync();
        Task<IDataResult<GetByIdTaskAutoAssignRuleDto>> GetByIdAsync(int taskAutoAssignRuleId);
    }
}
