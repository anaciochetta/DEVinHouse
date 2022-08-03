namespace EmpresaJ;

class FuncionarioNivel3 : Funcionario
{
    public int Codigo { get; set; }

    public FuncionarioNivel3() { }
    public FuncionarioNivel3(string nome, char sexo, int codigo) : base(nome, sexo)
    {
        Codigo = codigo;
    }

    public override double CalcularParticipacao()
    {
        return base.CalcularParticipacao() * 0.03;
    }

}