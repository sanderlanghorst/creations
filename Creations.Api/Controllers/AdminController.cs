using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Creations.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles ="Admin")]
    public class AdminController : ControllerBase
    {

        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCategories")]
        public IEnumerable<object> GetCategories()
        {
            return new List<object>();
        }
    }
}