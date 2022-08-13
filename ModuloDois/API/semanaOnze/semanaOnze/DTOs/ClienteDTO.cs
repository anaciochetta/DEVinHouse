namespace semanaOnze.DTOs;

public class ClienteDTO
{
    public string Nome { get; set; }
    public DateTime? DataNascimento { get; set; }
    //pode estar aqui pois é a relação de um p um
    public CarteiraTrabalhoDTO CarteiraTrabalho { get; set; }
}
