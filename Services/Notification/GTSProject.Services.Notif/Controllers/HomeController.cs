using GTSProject.Services.Notif.Services;
using Microsoft.AspNetCore.Mvc;

namespace GTSProject.Services.Notif.Controllers {
    [Route( "api/[controller]" )]
    [ApiController]
    public class HomeController : ControllerBase {

        private readonly RabbitMQService _rabbitMQService;

        public HomeController( RabbitMQService rabbitMQService ) {
            _rabbitMQService = rabbitMQService;
        }

        [HttpPost( "{message}/{user}/{type}" )]
        public IActionResult Post(  string message, string user, string type ) {
            try {
                _rabbitMQService.Publish( exchangeName: "ex", message: message, user: user, type: type );
                return Ok();
            }
            catch ( Exception ex ) {
                return StatusCode( 500, $"Internal server error\n{ex.Message}" );
            }
        }
    }
}