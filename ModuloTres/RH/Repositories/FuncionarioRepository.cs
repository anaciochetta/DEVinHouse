using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RH.Repositories
{
    public class FuncionarioRepository
    {

        //Lista de funcionários estática

        //Obter
        public IList<Funcionario> Get()
        {
            var funcionarios = lógica da lista;
            return funcionarios;
        }

        public IList<Funcionario> GetById(int id)
        {
            var funcionarios = lógica da lista.Find(id);
            return funcionarios;
        }

        //ObterPorUsuarioESenha
        public Funcionario GetByLoginAndPassword(string login, string senha)
        {
            var funcionario = lógica.Where(x => x.Senha == senha && x.Login == login);
            return funcionario;
        }

        //Adcionar - void??
        public void Add(Funcionario funcionario)
        {
            funcionario.Id = lógica de gerar id;
            lista.Add(funcionario);
        }

        //Editar
        public void Put(int id)
        {
            //não permite editar o id
            //lógica de editar
        }

        //Excluir
        public void Delete(Funcionario funcionario)
        {
            //lógica de editar
        }


    }
}