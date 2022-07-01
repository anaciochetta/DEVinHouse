using System.Text; //importe
namespace VsBug;


public static class Editor
{
    public static void Start()
    {
        Console.Clear(); //limpa o console

        Console.WriteLine("Modo Editor");
        Console.WriteLine(" (pressione ESC para finalizar)");
        Console.WriteLine("=================");

        Run();

    }

    public static void Run()
    {
        var htmlBuilder = new StringBuilder(string.Empty);
        htmlBuilder.Append(@"
        <!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta http-equiv='X-UA-Compatible' content='IE=edge'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>Document</title>
        </head>
        <body>
        ");

        do
        {
            var text = Console.ReadLine();
            htmlBuilder.Append(text);
            htmlBuilder.Append(Environment.NewLine);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        htmlBuilder.Append(@"
        </body>
        </html>");

        SaveFile(htmlBuilder.ToString());
    }

    public static void SaveFile(string content)
    {
        var directory = new DirectoryInfo("./arquivos");
        if (!directory.Exists)
            directory.Create(); //verifica e cria o diretório

        Console.Clear();
        Console.Write("Informe o nome do arquivo (sem a extensão): ");
        var fileName = Console.ReadLine();//pega o nome do arquivo

        var file = new StreamWriter($"{directory.FullName}/{fileName}.html"); //cria o caminho do arquivo
        file.Write(content); //salva o que foi escrito
        file.Close(); //fecha o arquivo para poder ser usado novamente

        Console.WriteLine($"O arquivo {fileName}.html foi salvo com sucesso em {directory.FullName}!");
        Console.ReadLine();
    }
}