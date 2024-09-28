using AutoMapper;
using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Business.Constants;
using GTSProject.Services.Core.UnitOfWork;
using GTSProject.Services.Core.Utilities.Results;
using GTSProject.Services.DataAccess.Concrete;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using GTSProject.Services.Entity.Concrete;

namespace GTSProject.Services.Business.Concrete
{
    public class TaskAutoAssignRuleManager : ITaskAutoAssignRuleService
    {
        private readonly IUnitOfWork<TaskServiceContext> _unitOfWork;
        private readonly IMapper _mapper;

        public TaskAutoAssignRuleManager(IUnitOfWork<TaskServiceContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IResult> AddAsync(CreateTaskAutoAssignRuleDto createTaskAutoAssignRuleDto)
        {
            var taskAutoAssignRule = _mapper.Map<TaskAutoAssignRule>(createTaskAutoAssignRuleDto);
            await _unitOfWork.GetRepository<TaskAutoAssignRule>().AddAsync(taskAutoAssignRule);
            await _unitOfWork.CompleteAsync();
            return new SuccessResult(Messages.TaskAutoAssignRuleAdded);
        }

        public async Task<IResult> DeleteAsync(int taskAutoAssignRuleId)
        {
            var taskAutoAssignRule = await _unitOfWork.GetRepository<TaskAutoAssignRule>().GetAsync(x => x.Id == taskAutoAssignRuleId);

            if (taskAutoAssignRule == null)
            {
                return new ErrorResult(Messages.TaskAutoAssignRuleNotFound);
            }

            await _unitOfWork.GetRepository<TaskAutoAssignRule>().DeleteAsync(taskAutoAssignRule);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.TaskAutoAssignRuleDeleted);
        }

        public async Task<IResult> UpdateAsync(UpdateTaskAutoAssignRuleDto updateTaskAutoAssignRuleDto)
        {
            var taskAutoAssignRule = await _unitOfWork.GetRepository<TaskAutoAssignRule>().GetAsync(x => x.Id == updateTaskAutoAssignRuleDto.Id);

            if (taskAutoAssignRule == null)
            {
                return new ErrorResult(Messages.TaskAutoAssignRuleNotFound);
            }

            _mapper.Map(updateTaskAutoAssignRuleDto, taskAutoAssignRule);
            await _unitOfWork.GetRepository<TaskAutoAssignRule>().UpdateAsync(taskAutoAssignRule);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.TaskAutoAssignRuleUpdated);
        }

        public async Task<IDataResult<List<ResultTaskAutoAssignRuleDto>>> GetAllAsync()
        {
            var taskAutoAssignRules = await _unitOfWork.GetRepository<TaskAutoAssignRule>().GetAllAsync();
            var result = _mapper.Map<List<ResultTaskAutoAssignRuleDto>>(taskAutoAssignRules);
            return new SuccessDataResult<List<ResultTaskAutoAssignRuleDto>>(result, Messages.TaskAutoAssignRuleListed);
        }

        public async Task<IDataResult<GetByIdTaskAutoAssignRuleDto>> GetByIdAsync(int taskAutoAssignRuleId)
        {
            var taskAutoAssignRule = await _unitOfWork.GetRepository<TaskAutoAssignRule>().GetAsync(x => x.Id == taskAutoAssignRuleId);

            if (taskAutoAssignRule == null)
            {
                return new ErrorDataResult<GetByIdTaskAutoAssignRuleDto>(Messages.TaskAutoAssignRuleNotFound);
            }

            var result = _mapper.Map<GetByIdTaskAutoAssignRuleDto>(taskAutoAssignRule);
            return new SuccessDataResult<GetByIdTaskAutoAssignRuleDto>(result, Messages.TaskAutoAssignRuleIdListed);
        }
    }
}
