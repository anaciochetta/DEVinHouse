using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using autenticacao.DTO;
using autenticacao.Services;
using autenticacao.Repositories;

namespace autenticacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] UserDTO dto)
        {

            var user = UserRepository.VerificarUsuarioESenha(dto);

            if (user == null) return Unauthorized();

            var token = TokenService.GenerateToken(user);

            return Ok(new { token });
        }

    }
}