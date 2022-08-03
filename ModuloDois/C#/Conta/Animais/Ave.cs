namespace Exercicios.Animais;

public class Ave : Animal
{
    public string Cor { get; set; }
    public Ave(string cor, string nome) : base(nome)
    {
        this.Cor = cor;
    }

    public void Voar(int altura)
    {
        System.Console.WriteLine($"Voando... em {altura} metros");
    }
}