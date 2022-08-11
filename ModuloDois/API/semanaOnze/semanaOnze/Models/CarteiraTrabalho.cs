namespace semanaOnze.Models;

public class CarteiraTrabalho
{
    public int Id { get; set; }
    public string PisPasep { get; set; }

    //chave estrangeira
    public int ClienteId { get; set; }
    //propriedade de navegação
    public Cliente Cliente { get; set; }
}
