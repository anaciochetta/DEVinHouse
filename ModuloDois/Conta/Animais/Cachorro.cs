namespace Exercicios.Animais;

class Cachorro : Mamifero
{
    public bool tipoLatido { get; set; }

    public Cachorro(bool tipoLatid0o, int velocidade, string nome) : base(velocidade, nome)
    {
        this.tipoLatido = tipoLatido;
    }
}