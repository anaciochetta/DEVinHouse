using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using autenticacao.Enums;

namespace autenticacao.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } //login
        public string Password { get; set; }
        public Permissoes Role { get; set; }
    }
}