namespace semanaOnze.Models;

public class Exame
{
    public int Id { get; set; }
    public string CodigoTuss { get; set; }
    public DateTime DataAgendamento { get; set; }

    //chave estrangeira
    public int ClienteId { get; set; }
    //propriedade de navegação
    public Cliente Cliente { get; set; }
}
