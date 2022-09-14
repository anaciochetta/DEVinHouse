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
        private readonly FuncionarioRepository _repository;

        public FuncionariosController(FuncionarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return _repository.Get();
        }

        [HttpGet]
        public IActionResult GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = _repository.GetByLoginAndPassword(login, senha);
            return funcionario;
        }

        [HttpDelete]
        public void Delete(Funcionario funcionario)
        {
            _repository.Delete(funcionario);
        }
    }
}