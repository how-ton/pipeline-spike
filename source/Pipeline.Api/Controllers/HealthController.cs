using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pipeline.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/health")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ping")]
        public string Ping()
        {
            return "pong";
        }
    }
}
