using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RH.DTOs
{
    public class FuncionarioDTO
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Salario { get; set; }
    }
}