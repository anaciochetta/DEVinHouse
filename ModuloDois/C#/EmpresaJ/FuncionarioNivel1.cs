namespace EmpresaJ;

class FuncionarioNivel1 : Funcionario
{
    public int Idade { get; set; }

    public FuncionarioNivel1() { }
    public FuncionarioNivel1(string nome, char sexo, int idade) : base(nome, sexo)
    {
        Idade = idade;
    }

    public override double CalcularParticipacao()
    {
        return base.CalcularParticipacao() * 0.01;
    }

}