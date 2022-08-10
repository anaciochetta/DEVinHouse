namespace aula0208.Models;

public class TipoCliente
{
    public int Id { get; set; }
    public string Nome { get; set; }

    public TipoCliente(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}