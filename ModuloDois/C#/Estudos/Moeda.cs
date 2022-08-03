using System.Globalization;
namespace Estudos;


public class Moedas
{
    public static void MoedasExemplo()
    {
        var valor = 12500.99M;
        var ptBR = new CultureInfo("pt-BR"); //configura a moeda para PT-BR
        System.Console.WriteLine(valor.ToString("C", ptBR));
        System.Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
    }
}