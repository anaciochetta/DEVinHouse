using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using RH.DTOs;

namespace RH.Repositories
{
    public static class FuncionarioRepository
    {

        public static List<Funcionario> funcionariosLista = new List<Funcionario>
        {
            new Funcionario{
                Id = new Guid("d381514d-17db-419c-93e6-d330ff84c12c"),
                Nome = "João",
                Email = "morango@gmail.com",
                Senha = "123",
                Permissao = Permissoes.Admnistrador,
                Salario = 5000
            },
            new Funcionario{
                Id = new Guid("d381514d-17db-419c-93e6-d330ff84c12c"),
                Nome = "Roberta",
                Email = "abacaxi@gmail.com",
                Senha = "321",
                Permissao = Permissoes.Funcionario,
                Salario = 5000
            },
            new Funcionario{
                Id = new Guid("d381514d-17db-419c-93e6-d330ff84c12c"),
                Nome = "Eduarda",
                Email = "banana@gmail.com",
                Senha = "213",
                Permissao = Permissoes.Gerente,
                Salario = 5000
            }
        };

        //Obter
        public static IList<Funcionario> Get()
        {
            return funcionariosLista;
        }

        public static Funcionario GetById(Guid id)
        {
            /* var funcionario = */
            return funcionariosLista.Find(x => x.Id == id);
        }

        //ObterPorUsuarioESenha
        public static Funcionario GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = funcionariosLista.FirstOrDefault(x => x.Email == login && x.Senha == senha);
            return funcionario;
        }

        //Adcionar 
        public static Funcionario Post(Funcionario funcionario)
        {
            funcionario.Id = Guid.NewGuid();
            funcionariosLista.Add(funcionario);

            return funcionario;
        }

        //Editar
        public static FuncionarioDTO Put(Guid id, FuncionarioDTO funcionarioEditado)
        {
            var funcionario = GetById(id);
            funcionario.Salario = funcionarioEditado.Salario;

            return funcionarioEditado;
        }

        //Excluir
        public static void Delete(Funcionario funcionario)
        {
            funcionariosLista.Remove(funcionario);
        }

    }
}