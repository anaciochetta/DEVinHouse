using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RH.Repositories;

namespace RH.DTOs
{
    public class FuncionarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Salario { get; set; }
        public Permissoes Permissao { get; set; }

        public FuncionarioDTO()
        {

        }
        public FuncionarioDTO(Funcionario funcionario)
        {
            Nome = funcionario.Nome;
            Senha = funcionario.Senha;
            Salario = funcionario.Salario;
            Permissao = funcionario.Permissao;
        }
    }
}