using GTSProject.Services.Business.Abstract;
using GTSProject.Services.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GTSProject.Services.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskAutoAssignRuleController : ControllerBase
    {
        private ITaskAutoAssignRuleService _taskAutoAssignRuleService;

        public TaskAutoAssignRuleController(ITaskAutoAssignRuleService taskAutoAssignRuleService)
        {
            _taskAutoAssignRuleService = taskAutoAssignRuleService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _taskAutoAssignRuleService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            var result = _taskAutoAssignRuleService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPost("Add")]
        public IActionResult Add(TaskAutoAssignRule taskAutoAssignRule)
        {
            var result = _taskAutoAssignRuleService.Add(taskAutoAssignRule);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPut("Update")]
        public IActionResult Update(TaskAutoAssignRule taskAutoAssignRule)
        {
            var result = _taskAutoAssignRuleService.Update(taskAutoAssignRule);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpDelete("Delete")]
        public IActionResult Delete(TaskAutoAssignRule taskAutoAssignRule)
        {
            var result = _taskAutoAssignRuleService.Delete(taskAutoAssignRule);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest();
        }
    }
}
