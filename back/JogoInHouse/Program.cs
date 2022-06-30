using JogoInHouse.Models;
namespace JogoInHouse;

class Program
{
    static void Main(string[] args)
    {
        var monstro = new Monstro("Bug", "Malware");
        var jogador = new Jogador("Goku", "Sayajin", 3);

        do
        {
            RodarJogo(monstro, jogador);
        } while (monstro.PontosVida >= 0);
        Console.WriteLine("");
        Console.WriteLine($"Parabéns você derrotou o monstro {monstro.Nome}");
    }

    public static void RodarJogo(Monstro monstro, Jogador jogador)
    {
        Console.Clear();

        Console.WriteLine($"Você está jogando contra um {monstro.Nome} de nível {monstro.Nivel}!");
        Console.WriteLine($"Ele tem {monstro.PontosVida} de vida");
        Console.WriteLine("");
        Console.WriteLine("1 - Atacar!");
        Console.WriteLine("2 - Sair correndo!");
        Console.Write("Digite a ação: ");
        var opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1": jogador.Atacar(monstro); break;
            case "2": Environment.Exit(0); break;
            default: RodarJogo(monstro, jogador); break;
        }

    }
}