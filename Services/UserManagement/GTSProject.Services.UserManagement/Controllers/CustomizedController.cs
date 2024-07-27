using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagementSystem.Models.Dtos.BaseDtos;

namespace UserManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomizedController : ControllerBase
    {
        public CustomizedController()
        {

        }

        public IActionResult ActionResultInstance<T>(ResponseDto<T> response) where T : class
        {


            return new ObjectResult(response)
            {
                StatusCode = response.status
            };
        }
    }
}
