using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pipeline.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public WeatherForecastController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Ping()
        {
            return "Pong";
        }
    }
}
