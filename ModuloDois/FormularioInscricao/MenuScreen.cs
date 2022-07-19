namespace FormularioInscricao;

public class MenuScreen
{
    public static void Init(CursoSelecionado cursos)
    {
        ShowOptions(cursos);
    }

    static void ShowOptions(CursoSelecionado cursos)
    {
        Console.WriteLine("Formulário de cursos");
        Console.WriteLine("---------------------------------");

        Console.WriteLine("1 - Preencher inscrição");
        Console.WriteLine("2 - Listar Cursos");
        Console.WriteLine("0 - Sair");


        Console.Write("Digite a opção: ");

        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                FormularioScreen.Init(cursos);
                break;
            case 2:
                ListarCursosScreen.Init(cursos);
                break;
            case 0:
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Init(cursos);
                break;
        }
    }
}
