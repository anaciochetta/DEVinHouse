namespace Exercicios;

class ContaPoupança : Conta
{
    public double TaxaJuros { get; set; }

    public ContaPoupança(double taxaJuros, string nomeTitularConta, int numero, double saldoConta) : base(nomeTitularConta, numero, saldoConta)
    {
        TaxaJuros = taxaJuros;
    }

    public void AtualizarSaldo()
    {
        SaldoConta += SaldoConta * TaxaJuros;
    }
}