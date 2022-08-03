namespace Exercicios;

//classe específica
class ContaPJ : Conta
{
    public Double LimitePreco { get; set; }

    //base (parametros) reaproveita o construtor da classe herdada
    public ContaPJ(string nomeTitularConta, int numero, double saldoConta, double limitePreco) : base(nomeTitularConta, numero, saldoConta)
    {
        this.LimitePreco = limitePreco;
    }

    public void Emprestimo(double valorEmprestimo)
    {
        if (valorEmprestimo <= LimitePreco)
        {
            SaldoConta += valorEmprestimo;
        }
    }
}