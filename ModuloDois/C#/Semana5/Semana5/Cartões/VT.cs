namespace Semana5.Cartoes;

public class ValeTransporte : Cartao
{
    public ValeTransporte(string bandeira, double saldo, double valorTaxa) : base(bandeira, saldo, valorTaxa)
    { }
    public override double VerificarValorTaxaCartao(double saldo, double valorTaxa)
    {
        return base.VerificarValorTaxaCartao(saldo, 0.15);
    }
}