namespace VsBug;

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
                Editor.Start();
                break;
            case 2: break;
            case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            default:
                Show();
                break;
        }

        Console.ReadLine();
    }

    static void ShowOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("VsBUG Editor v0.1");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("=================");

        Console.SetCursorPosition(3, 5);
        Console.WriteLine("1 - Novo Arquivo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("2 - Ler Arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(3, 10);
        Console.Write("Opção Selecionada: ");
    }
    static void DrawCanvas()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;

        PrintHorizontalLine(); //chamar método

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
    static void PrintHorizontalLine() //void pq não retorna nada
    {
        Console.Write("+");
        for (int i = 0; i <= 45; i++)
            Console.Write("-"); //pode deixar sem os {}

        Console.Write("+");
        Console.Write(Environment.NewLine);
    }
}