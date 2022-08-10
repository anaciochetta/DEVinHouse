using aula0208.Models;

namespace aula0208.ViewModel
{
    public class ClienteComContasViewModel
    {
        public string Nome { get; set; }
        public List<Conta>  Contas { get; set; }

        public ClienteComContasViewModel(string nome, List<Conta> contas)
        {
            Nome = nome;
            Contas = contas;
        }
    }
}
