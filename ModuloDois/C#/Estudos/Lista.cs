namespace Estudos;

public class ListaExemplos
{
    public static void List()
    {
        IList<string> listaDeNomes = new List<string>();//inicializador da lista

        listaDeNomes.Add("Beth");
        listaDeNomes.Add("Bisco");
        listaDeNomes.Add("Mingau");

        foreach (var nome in listaDeNomes)
        {
            System.Console.WriteLine(nome);
        }
    }
}