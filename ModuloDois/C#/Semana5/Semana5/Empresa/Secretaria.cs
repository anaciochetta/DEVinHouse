namespace Semana5;

class Secretaria : SalarioEmpregado
{
    public int AnosEmpresa { get; set; }

    public Secretaria() { }
    public Secretaria(int id, string nome, int codigoFuncionario, double valorSalario, int anosEmpresa) : base(id, nome, codigoFuncionario, valorSalario)
    {
        AnosEmpresa = anosEmpresa;
    }

    void AtenderClientes() { }
    void RealizarLigacoes() { }
}