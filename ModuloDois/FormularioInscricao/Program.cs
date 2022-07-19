namespace FormularioInscricao;

class Program
{
    static void Main(string[] args)
    {
        CursoSelecionado Cursos = new();

        MenuScreen.Init(Cursos);
    }
}

