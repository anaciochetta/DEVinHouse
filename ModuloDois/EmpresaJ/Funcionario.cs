namespace EmpresaJ;

class Funcionario
{

    public string Nome { get; set; }
    public char Sexo { get; set; }

    public Funcionario() { }

    public Funcionario(string nome, char sexo)
    {
        Nome = nome;
        Sexo = sexo;
    }

    //método virtual, permite polimorfismo nas sub-classes
    public virtual double CalcularParticipacao()
    {
        return 1000;
    }
}