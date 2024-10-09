using Microsoft.AspNetCore.Mvc;
using GTSProject.Services.Core.Utilities.Results;

namespace GTSProject.Services.Core.WebApi
{
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        protected IActionResult CreateActionResult(IResult result)
        {
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        protected IActionResult CreateActionResult<T>(IDataResult<T> result)
        {
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return NotFound(result.Message);
        }
    }
}
