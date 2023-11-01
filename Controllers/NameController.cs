using Microsoft.AspNetCore.Mvc;

namespace Kuchta_Ethan_GitAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : Controller
    {
        private readonly ILogger<NameController> _name;
        public NameController(ILogger<NameController> logger)
        {
            _name = logger;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var name = new Name { firstName = "Ethan", lastName = "Kuchta" };
            return Ok(name);
        }
    }
}
