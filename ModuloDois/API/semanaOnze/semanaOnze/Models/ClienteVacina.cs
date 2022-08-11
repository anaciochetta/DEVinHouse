namespace semanaOnze.Models;

public class ClienteVacina
{
    //propriedade adcionada por lógica
    public DateTime DataAplicacao { get; set; }

    //chaves estrangeiras
    public int ClienteId { get; set; }
    public int VacinaId { get; set; }

    //propriedades de navegação
    public Vacina Vacina { get; set; }
    public Cliente Cliente { get; set; }
}
