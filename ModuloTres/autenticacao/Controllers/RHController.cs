using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using autenticacao.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace autenticacao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RHController : ControllerBase
    {
        [HttpGet]
        [Route("Diretores")]
        //seta quais tipos de usuários podem acessar
        //permissão de diretor - dentro do token vem essa informação
        [Authorize(Roles = "Diretor")]
        public IActionResult AcessoDiretores()
        {
            //identity -> recupera informações do token 
            var name = User?.Identity?.Name;
            return Ok($"Bem-vindo, {name}. Área exclusiva de diretores");
        }

        [HttpGet]
        [Route("Professores")]
        //o ideal é que tivesse um midleware no lugar de professor, pois se mudar o nome nos enum daria erro em tudo
        [Authorize(Roles = "Professor,Diretor")]
        public IActionResult AcessoProfessores()
        {
            //is in role -> retorno o valor que indica qual o role
            var ehDiretor = User.IsInRole(Permissoes.Diretor.GetDisplayName());
            //se for diretor 
            if (ehDiretor)
                return Ok("Área exclusiva de professores. Bem-vindo, Diretor");
            else
                return Ok("Área exclusiva de professores, Bem-vindo Professor");

        }
    }
}