namespace GeraEstoque;

public static class ExemploMenu
{
    public static void ExemploMenus()
    {
        ConsoleKeyInfo key;
        bool isEnter = true;
        while (isEnter)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Welcome! \n");
            Console.WriteLine("Press ENTER to continue or ESC to quit.");
            key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Escape)
            {
                isEnter = false;
                break;
            }
            else if (key.Key == ConsoleKey.Enter)
            {

                Console.Clear();
                System.Console.WriteLine("continua....");
            }

        }
    }
}