namespace Semana5.Cartoes;

public class Cartao
{
    public string Bandeira { get; set; }
    public Double Saldo { get; set; }
    public Double ValorTaxa { get; set; }

    public Cartao() { }
    public Cartao(string bandeira, double saldo, double valorTaxa)
    {
        Bandeira = bandeira;
        Saldo = saldo;
        ValorTaxa = valorTaxa;
    }

    public virtual Double VerificarValorTaxaCartao(double saldo, double valorTaxa)
    {
        double taxa = valorTaxa * saldo;
        double saldoComTaxa = saldo - taxa;
        return saldoComTaxa;
    }

    public string MostrarInfo()
    {
        return $"Bandeira: {Bandeira} | Saldo: {Saldo}";
    }
}