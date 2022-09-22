using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RH.DTOs;
using RH.Repositories;
using RH.Services;

namespace RH.Controller
{
    public class AutenticacaoController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDTO dto)
        {

            var user = FuncionarioRepository.GetByLoginAndPassword(dto.Email, dto.Senha);

            if (user == null) return Unauthorized();

            var token = TokenService.GenerateToken(user);

            return Ok(new { token });
        }
    }
}