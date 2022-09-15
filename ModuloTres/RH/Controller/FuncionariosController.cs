using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RH.Repositories;

namespace RH.Controller
{
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = FuncionarioRepository.Get();
            if (funcionarios == null)
            {
                return NoContent();
            }
            return Ok(funcionarios);
        }

        [HttpGet]
        public IActionResult GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = FuncionarioRepository.GetByLoginAndPassword(login, senha);
            return Ok(funcionario);
        }

        [HttpDelete]
        public void Delete(Funcionario funcionario)
        {
            FuncionarioRepository.Delete(funcionario);
        }
    }
}