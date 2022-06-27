namespace GeraEstoque;

public class Menu
{
    public static void Show()
    {
        Console.Clear();
        DrawCanvas();
        ShowOptions();

        var option = short.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Register.ProductRegister();
                break;
            case 2: break;
            case 0:
                Console.Clear();
                Environment.Exit(0);
                break;
            default:
                Show();
                break;
        }
    }
    static void ShowOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Seja bem vindo ao GeraEstoque 1.0");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        Console.SetCursorPosition(3, 5);
        Console.WriteLine("1 - Cadastrar Produto");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("2 - Consultar Produto");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("3 - Modificar Produto");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("4 - Excluir Produto");
        Console.SetCursorPosition(3, 9);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(3, 12);
        Console.Write("Digite a opção: ");
    }
    public static void DrawCanvas()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;

        PrintHorizontalLine();

        for (int line = 0; line <= 12; line++)
        {
            Console.Write("|");
            for (int i = 0; i <= 45; i++)
                Console.Write(" ");

            Console.Write("|");
            Console.Write(Environment.NewLine);
        }

        PrintHorizontalLine();
    }
    public static void PrintHorizontalLine()
    {
        Console.Write("+");
        for (int i = 0; i <= 45; i++)
            Console.Write("-");

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }
}