using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using autenticacao.DTO;
using autenticacao.Enums;
using autenticacao.Models;

namespace autenticacao.Repositories
{
    public static class UserRepository
    {
        //lista estática que vai funcionar como database
        private static List<User> usuarios = new List<User>
        {
            new User{
                Id = 1,
                Name = "Ana",
                Email = "ana@gmail.com",
                Password = "123",
                Role = Permissoes.Diretor
            },
            new User{
                Id = 1,
                Name = "João",
                Email = "joão@gmail.com",
                Password = "123",
                Role = Permissoes.Professor
            }
        };
        public static User VerificarUsuarioESenha(UserDTO dto)
        {
            var user = usuarios.FirstOrDefault
                        (x => x.Email == dto.Email && x.Password == dto.Password);

            return user;
        }
    }
}