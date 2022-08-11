using Microsoft.AspNetCore.Mvc;

namespace semanaOnze.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}