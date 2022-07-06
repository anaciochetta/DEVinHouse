using Exercicios.Animais;
namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        //Exemplo um Conta
        ContaPJ contaPessoaJuridica = new ContaPJ("Jaime", 810, 100.0, 500.0);

        Console.WriteLine($"Saldo: {contaPessoaJuridica.SaldoConta} reais");

        //contaPessoaJuridica.SaldoConta += 100; -> não consegue usar por causa do protected no set
        contaPessoaJuridica.Emprestimo(100);
        contaPessoaJuridica.Deposito(100);

        contaPessoaJuridica.Saque(50.5);
        Console.WriteLine($"Saldo: {contaPessoaJuridica.SaldoConta} reais");

        //Upcasting
        Conta contaUp = contaPessoaJuridica;


        //Exemplo de Try e Catch
        //Exemplo.TryCatch();
        //Exemplo.TryCatchAvancado();


        /* Exemplo Animais - Herança
        Animal animal = new Animal("bob");
        System.Console.WriteLine($"Nome do primeiro animal é: {animal.Nome}");

        Mamifero mamifero = new Mamifero(15, "robson");
        System.Console.WriteLine($"Nome do mamifero é {mamifero.Nome}, e ele chega a {mamifero.Velocidade}km/h");
        mamifero.Falar("Robson fala");

        Cachorro cachorro = new Cachorro(true, 5, "beth");
        System.Console.WriteLine($"Nome do mamifero é {cachorro.Nome}, e ele chega a {cachorro.Velocidade}km/h");
        cachorro.Correr();
        cachorro.Falar("auau");

        Vaca vaca = new Vaca(true, "Mimosa", 2);
        vaca.Falar("muuuuu");
        vaca.Ordenhar(); */

    }
}