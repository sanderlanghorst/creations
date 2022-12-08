using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Creations.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "User")]
    public class CreationsController : ControllerBase
    {

        private readonly ILogger<AdminController> _logger;

        public CreationsController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCreation")]
        public object Get()
        {
            return new { };
        }
    }
}