namespace semanaOnze.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime? DataNascimento { get; set; } //? não obrigatório - pode ser nulo

    //propriedade de navegação inversa
    public CarteiraTrabalho CarteiraTrabalho { get; set; }

    //registros associados ao registro, pois é n->n
    public List<Exame> Exames { get; set; }
    public List<ClienteVacina> Vacinas { get; set; }
}
