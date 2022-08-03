namespace EmpresaJ;

class FuncionarioNivel2 : Funcionario
{
    public string Cargo { get; set; }

    public FuncionarioNivel2() { }
    public FuncionarioNivel2(string nome, char sexo, string cargo) : base(nome, sexo)
    {
        Cargo = cargo;
    }

    public override double CalcularParticipacao()
    {
        return base.CalcularParticipacao() * 0.02;
    }

}