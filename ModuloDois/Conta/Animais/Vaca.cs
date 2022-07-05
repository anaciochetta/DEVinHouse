namespace Exercicios.Animais;

class Vaca : Mamifero
{
    public bool PermiteOrdenha { get; set; }

    public Vaca(bool permiteOrdenha, string nome, int velocidade) : base(velocidade, nome)
    {
        PermiteOrdenha = permiteOrdenha;
    }

    public void Ordenhar()
    {
        System.Console.WriteLine("Ordenhando...");
    }
}