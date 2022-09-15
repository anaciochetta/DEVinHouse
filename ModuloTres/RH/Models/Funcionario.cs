using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RH.Repositories
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Permissoes Permissao { get; set; }
        public int Salario { get; set; }
    }
}