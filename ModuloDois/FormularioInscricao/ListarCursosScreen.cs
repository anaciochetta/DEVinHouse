namespace FormularioInscricao;

public static class ListarCursosScreen
{
    public static void Init(CursoSelecionado cursos)
    {
        Console.Clear();
        ListarCursos(cursos);
    }
    static void ListarCursos(CursoSelecionado cursos)
    {
        System.Console.WriteLine("Lista de cursos cadastrados:");
        System.Console.WriteLine();

        if (cursos.Cursos.Count == 0)
        {
            System.Console.WriteLine("Não há cursos cadastrados!");
        }
        else
        {
            foreach (var curso in cursos.Cursos)
            {
                CobrarCurso custo = new(curso.ValorCurso, curso.ValorMulta, curso.ValorDesconto);
                if (curso.ValorDesconto == 0)
                {
                    string txt = FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso);
                    Console.WriteLine(txt);
                }
                else if (curso.ValorDesconto > 0 && curso.Idade < 18)
                {
                    string txt = FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso, curso.ValorDesconto, curso.Idade);
                    Console.WriteLine(txt);

                }
                else if (curso.ValorDesconto > 0)
                {
                    string txt = FormatacaoTexto.Formatacao(curso.Nome, curso.Curso, curso.ValorCurso, curso.ValorDesconto);
                    Console.WriteLine(txt);

                }
            }
        }
    }
}