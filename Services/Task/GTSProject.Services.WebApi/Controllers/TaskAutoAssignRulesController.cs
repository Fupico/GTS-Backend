using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Core.Utilities.Results;
using GTSProject.Services.Dto.TaskAutoAssignRuleDtos;
using Microsoft.AspNetCore.Mvc;
using IResult = GTSProject.Services.Core.Utilities.Results.IResult;

namespace GTSProject.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAutoAssignRulesController : ControllerBase
    {
        private readonly ITaskAutoAssignRuleService _taskAutoAssignRuleService;

        public TaskAutoAssignRulesController(ITaskAutoAssignRuleService taskAutoAssignRuleService)
        {
            _taskAutoAssignRuleService = taskAutoAssignRuleService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            IDataResult<List<ResultTaskAutoAssignRuleDto>> result = await _taskAutoAssignRuleService.GetAllAsync();

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound(result.Message);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            IDataResult<GetByIdTaskAutoAssignRuleDto> result = await _taskAutoAssignRuleService.GetByIdAsync(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return NotFound(result.Message);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateTaskAutoAssignRuleDto createTaskAutoAssignRuleDto)
        {
            IResult result = await _taskAutoAssignRuleService.AddAsync(createTaskAutoAssignRuleDto);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateTaskAutoAssignRuleDto updateTaskAutoAssignRuleDto)
        {
            IResult result = await _taskAutoAssignRuleService.UpdateAsync(updateTaskAutoAssignRuleDto);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            IResult result = await _taskAutoAssignRuleService.DeleteAsync(id);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
