namespace Semana5.Cartoes;

public static class Programa
{
    public static void Init()
    {
        Ex2();
    }

    static void Ex2()
    {
        //exercício 2
        ValeAlimentacao va = new("Sodexo Alimentação", 100, 0.02);
        double taxaVA = va.VerificarValorTaxaCartao(100, 0.02);

        ValeTransporte vt = new("Estrela", 100, 0.02);
        double taxaVT = vt.VerificarValorTaxaCartao(350, 0.02);

        ValeRefeicao vr = new("Sodexo Refeição", 100, 0.02);
        double taxaVR = vr.VerificarValorTaxaCartao(600, 0.02);

        System.Console.WriteLine($"Exercício 2\n VA: {va.MostrarInfo()} | Saldo com Taxa: {taxaVA}\n VT: {vt.MostrarInfo()}| Saldo com Taxa: {taxaVT}\n VR: {vr.MostrarInfo()}| Saldo com Taxa: {taxaVR}");
    }

    static void Ex3()
    {
        //upcasting
        Cartao vale = new ValeAlimentacao();

        //downcasting
        ValeAlimentacao vA = (ValeAlimentacao)vale;
    }
}