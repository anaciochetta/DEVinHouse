namespace Exercicios.Animais;

public class Papagaio : Ave
{
    public string Vocabulario { get; set; }

    public Papagaio(string vocabulario, string cor, string nome) : base(nome, cor)
    {
        Vocabulario = vocabulario;
    }

}