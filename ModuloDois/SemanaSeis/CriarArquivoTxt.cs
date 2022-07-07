namespace SemanaSeis;
using System.Text;

public static class CriarArquivoTxt
{
    public static void CriarArquivoTxtExemplo()
    {
        StringBuilder stringBuilder = new();
        //StringBuilder stringBuilder = new StringBuilder();
        stringBuilder!.AppendLine("Aula 01");
        stringBuilder!.AppendLine($"Data e hora: {DateTime.Now}");

        var file = "C:\Users\ANA\Desktop\dev\DEVinHouse\ModuloDois\SemanaSeis";

        //escrever o arquivo
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(file))
            {
                streamWriter.WriteLine(stringBuilder);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao escrever o arquio", ex);
        }

        //ler o arquivo
        using (StreamReader reader = new StreamReader(file)) { }
    }
}

