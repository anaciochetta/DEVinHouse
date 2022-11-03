using api.Models;
using api.Repositories;

namespace api.Services;

public class RiscoService
{
    //altura pes
    //distancia <300m = risco 100
    //distancia >301 <600m = risco 50
    //distancia >601 <1200m = risco 20
    //distancia >1200m = risco 0

    //risco vai 0 a 100

    public static int getRiscoFrom(int id, List<ObjetoAereo> objetosNoAr)
    {
        var objetoEmQuestao = objetosNoAr.Find(item => item.Id == id);
        //todos menos o obj em questão
        objetosNoAr = objetosNoAr.Where(item => item.Id != id).ToList();

        if (objetoEmQuestao == null) { throw new Exception("Nenhum objeto encontrado para este id"); };

        int maiorRisco = 0;

        foreach (var item in objetosNoAr)
        {
            double distancia = GetDistanciaEntreDoisPontos(objetoEmQuestao, item);
            var riscoIdentificado = 0;
            Console.WriteLine(distancia);

            riscoIdentificado = IdentificaRiscoPorMetro(distancia);

            if (riscoIdentificado > maiorRisco)
            {
                maiorRisco = riscoIdentificado;
            }
        }
        return maiorRisco;
    }

    public static int IdentificaRiscoPorMetro(double distancia)
    {
        var riscoIdentificado = 0;
        if (distancia < 301)
        {
            riscoIdentificado = 100;
        }
        if (distancia > 301 && distancia < 601)
        {
            riscoIdentificado = 50;
        }
        if (distancia > 601)
        {
            riscoIdentificado = 0;
        }

        return riscoIdentificado;
    }

    public static double GetDistanciaEntreDoisPontos(ObjetoAereo obj1, ObjetoAereo obj2)
    {

        var distanceKM = Math.Sqrt((Math.Pow(obj1.Latitude - obj2.Latitude, 2) + Math.Pow(obj1.Longitude - obj2.Longitude, 2)));
        return (Int32)Math.Round(1000 + distanceKM, 0);
    }
}
