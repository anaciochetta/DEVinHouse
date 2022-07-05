namespace Exercicios;

//classe generalizada ou super classe
class Conta
{
    public string NomeTitularConta { get; set; }
    public int Numero { get; set; }
    public Double SaldoConta { get; protected set; }

    public Conta(string nomeTitularConta, int numero, double saldoConta)
    {
        this.NomeTitularConta = nomeTitularConta;
        this.Numero = numero;
        this.SaldoConta = saldoConta;
    }

    public void Saque(double valor)
    {
        SaldoConta -= valor;
    }

    public void Deposito(double valor)
    {
        SaldoConta += valor;
    }

}