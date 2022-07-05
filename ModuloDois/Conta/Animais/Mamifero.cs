namespace Exercicios.Animais;

public class Mamifero : Animal
{
    public int Velocidade { get; set; }

    //public Mamifero() { }

    public Mamifero(int velocidade, string nome) : base(nome)
    {
        Velocidade = velocidade;
    }

    public void Correr()
    {
        System.Console.WriteLine("Correndo...");
    }
}