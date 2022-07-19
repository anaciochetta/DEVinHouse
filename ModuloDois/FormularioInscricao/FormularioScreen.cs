namespace FormularioInscricao;

public class FormularioScreen
{
    public static void Init(CursoSelecionado cursos)
    {
        Console.Clear();
        TelaIncial(cursos);
    }
    private static void TelaIncial(CursoSelecionado cursos)
    {
        Console.WriteLine("Preencha o formulário com os seus dados: ");
        Console.WriteLine("Nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Data de Nascimento: ");
        var dataNascimento = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Curso: ");
        var curso = Console.ReadLine();
        Console.WriteLine("Escolaridade: ");
        var escolaridade = Console.ReadLine();
        Console.WriteLine("Valor do Curso: ");
        var valorCurso = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor do Desconto: ");
        var valorDesconto = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor da Multa: ");
        var valorMulta = int.Parse(Console.ReadLine());

        cursos.Cursos.Add(new FichaInscricao(nome, curso, escolaridade, valorCurso, valorDesconto, valorMulta, dataNascimento));

        FichaInscricao ficha = new(nome, curso, escolaridade, valorCurso, valorDesconto, valorMulta, dataNascimento);

        SalvarFicha(ficha);
    }

    private static void SalvarFicha(FichaInscricao ficha)
    {
        if (ficha.ValorDesconto == 0)
        {
            string txt = FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso);
            Console.WriteLine(txt);
        }
        else if (ficha.ValorDesconto > 0 && ficha.Idade < 18)
        {
            string txt = FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDesconto, ficha.Idade);
            Console.WriteLine(txt);

        }
        else if (ficha.ValorDesconto > 0)
        {
            string txt = FormatacaoTexto.Formatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDesconto);
            Console.WriteLine(txt);

        }
    }
}

