using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RH.Repositories
{
    public static class FuncionarioRepository
    {

        public static List<Funcionario> funcionariosLista = new List<Funcionario>
        {
            new Funcionario{
                Id = 1,
                Nome = "João",
                Email = "joão@gmail.com",
                Senha = "123",
                Permissao = Permissoes.Admnistrador,
                Salario = 5000
            }
        };

        //Obter
        public static IList<Funcionario> Get()
        {
            return funcionariosLista;
        }

        public static Funcionario GetById(int id)
        {
            var funcionarios = funcionariosLista.FirstOrDefault(x => x.Id == id);
            return funcionarios;
        }

        //ObterPorUsuarioESenha
        public static Funcionario GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = funcionariosLista.FirstOrDefault(x => x.Email == login && x.Senha == senha);
            return funcionario;
        }

        //Adcionar - void??
        public static void Add(Funcionario funcionario)
        {
            //funcionario.Id = lógica de gerar id;
            funcionariosLista.Add(funcionario);
        }

        //Editar
        public static void Put(int id)
        {
            //não permite editar o id
            //lógica de editar
        }

        //Excluir
        public static void Delete(Funcionario funcionario)
        {
            //lógica de editar
        }


    }
}