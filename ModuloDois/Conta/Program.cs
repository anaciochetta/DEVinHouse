using Exercicios.Animais;
namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        //Exemplo um Conta
        ContaPJ contaPessoaJuridica = new ContaPJ("Jaime", 810, 100.0, 500.0);

        //Console.WriteLine($"Saldo: {contaPessoaJuridica.SaldoConta} reais");

        //contaPessoaJuridica.SaldoConta += 100; -> não consegue usar por causa do protected no set
        contaPessoaJuridica.Emprestimo(100);
        contaPessoaJuridica.Deposito(100);

        contaPessoaJuridica.Saque(50.5);
        //Console.WriteLine($"Saldo: {contaPessoaJuridica.SaldoConta} reais");



        //Exemplo de Try e Catch
        //Exemplo.TryCatch();
        //Exemplo.TryCatchAvancado();


    }
}