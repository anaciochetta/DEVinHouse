namespace Semana5;

class SalarioEmpregado : Empregado
{


    public int CodigoFuncionario { get; set; }
    public Double ValorSalario { get; set; }

    public SalarioEmpregado() { }
    public SalarioEmpregado(int id, string nome, int codigoFuncionario, double valorSalario) : base(id, nome)
    {
        CodigoFuncionario = codigoFuncionario;
        ValorSalario = valorSalario;
    }

    void CalcularFolhaPagamento() { }
}