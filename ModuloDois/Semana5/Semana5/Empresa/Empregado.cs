namespace Semana5;

class Empregado
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public Empregado() { }
    public Empregado(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }

    void Trabalhar() { }
    void IrEmbora() { }
    void TirarFolga() { }
}