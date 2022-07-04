namespace Empresa;

class Departamento
{
    public int Id { get; set; }
    public string DescricaoDepartamento { get; set; }
    public int CentroDeCusto { get; set; }
    public Funcionario FuncionarioNoDepartamento { get; set; }
    public CentroDeCusto CentroDeCustoDoDepartamento { get; set; }

    private Departamento() { } //bloqueia para precisar começar a o departamento com o centro de custo
    public Departamento(CentroDeCusto centroDeCusto)
    {
        if (centroDeCusto == null)
        {
            throw new Exception("Erro no Centro de Custo");
        }

        CentroDeCustoDoDepartamento = centroDeCusto;
    }

    public void InserirFuncionarioNoDepartamento()
    {
        Console.WriteLine($"Descrição do departamento: {DescricaoDepartamento}");
        System.Console.WriteLine($"Centro de custo: {CentroDeCusto}");
        //@ antes do " para adcionar quebra de linha
        System.Console.WriteLine($@"Id do funcionário: {FuncionarioNoDepartamento.Id};
        Nome do funcionário: {FuncionarioNoDepartamento.Nome};
        Data de nascimento: {FuncionarioNoDepartamento.DataNascimento}");
    }
}