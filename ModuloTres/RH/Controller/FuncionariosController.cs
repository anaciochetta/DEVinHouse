using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RH.DTOs;
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
            return Ok(funcionarios);
        }

        [HttpGet]
        [Route("login-senha")]
        public IActionResult GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = FuncionarioRepository.GetByLoginAndPassword(login, senha);
            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult Post([FromBody] FuncionarioDTO funcionario)
        {
            var novoFuncionario = new Funcionario
            {
                Nome = funcionario.Nome,
                Email = funcionario.Email,
                Senha = funcionario.Senha,
                Salario = funcionario.Salario
            };

            FuncionarioRepository.Post(novoFuncionario);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] FuncionarioDTO funcionario)
        {

            var novoF = FuncionarioRepository.Put(id, funcionario);
            return Ok(novoF);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            var funcionario = FuncionarioRepository.GetById(id);
            FuncionarioRepository.Delete(funcionario);

        }
    }
}