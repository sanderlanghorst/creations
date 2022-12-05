using Microsoft.AspNetCore.Mvc;

namespace Creations.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {

        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get")]
        public object Get()
        {
            return new { };
        }
    }
}