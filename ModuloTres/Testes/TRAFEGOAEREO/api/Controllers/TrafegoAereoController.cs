using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class TrafegoAereoController : ControllerBase
{
    
    [HttpGet(Name = "GetRisco")]
    public int Get(int id)
    {  
        return RiscoService.getRiscoFrom(id);
    }
}
