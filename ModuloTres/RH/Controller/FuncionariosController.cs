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
using Microsoft.AspNetCore.Authorization;
using Microsoft.OpenApi.Extensions;

namespace RH.Controller
{
    [Route("[controller]")]
    public class FuncionariosController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            if (User.IsInRole(Permissoes.Funcionario.GetDisplayName()))
            {
                return Ok((FuncionarioRepository.Get()).Select(f => new { f.Nome, f.Permissao }));
            }
            var funcionarios = FuncionarioRepository.Get();
            return Ok(funcionarios);
        }

        [Authorize]
        [HttpGet]
        [Route("login-senha")]
        public IActionResult GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = FuncionarioRepository.GetByLoginAndPassword(login, senha);
            return Ok(funcionario);
        }

        //cadastrar-novo-funcionario
        [Authorize(Roles = "Administrador")]
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

        //alterar-salario
        [Authorize(Roles = "Gerente")]
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] FuncionarioDTO funcionario)
        {
            var funcionarioEditado = FuncionarioRepository.Put(id, funcionario);
            return Ok(funcionarioEditado);
        }

        [Authorize(Roles = "Administrador, Gerente")]
        //excluir-funcionario
        [HttpDelete]
        public ActionResult Delete(Guid id)
        {
            var funcionario = FuncionarioRepository.GetById(id);
            FuncionarioRepository.Delete(funcionario);
            return NoContent();
        }

        [Authorize(Roles = "Administrador")]
        //excluir-gerente
        [HttpDelete("delete-gerente")]
        public ActionResult DeleteGerente(Guid id)
        {
            var funcionario = FuncionarioRepository.GetById(id);
            FuncionarioRepository.Delete(funcionario);
            return NoContent();
        }
    }
}