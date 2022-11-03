using api.Repositories;
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
        var objetosNoAr = ObjetosAereosRepository.GetAll();
        return RiscoService.getRiscoFrom(id, objetosNoAr);
    }
}
