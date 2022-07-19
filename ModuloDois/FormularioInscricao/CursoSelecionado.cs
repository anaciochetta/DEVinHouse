namespace FormularioInscricao;

public class CursoSelecionado
{
    public IList<FichaInscricao> Cursos { get; set; }

    public CursoSelecionado()
    {
        List<FichaInscricao> Cursos = new();
    }
}