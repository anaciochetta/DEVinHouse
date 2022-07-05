namespace Exercicios.Animais;

public class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public void Imprime()
    {
        System.Console.WriteLine("Imprimiu");
    }

    public void Falar(string tipo)
    {
        System.Console.WriteLine(tipo);
    }

}