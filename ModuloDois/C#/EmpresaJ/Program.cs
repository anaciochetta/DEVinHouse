namespace EmpresaJ;

class Program
{
    static void Main(string[] args)
    {
        Funcionario dono = new Funcionario();
        dono.Nome = "João";
        System.Console.WriteLine($"Nome do dono: {dono.Nome}, a sua participação é de {dono.CalcularParticipacao()} reais");

        FuncionarioNivel1 funcionario1 = new FuncionarioNivel1();
        funcionario1.Nome = "Maria";

        FuncionarioNivel2 funcionario2 = new FuncionarioNivel2();
        funcionario2.Nome = "Isma";

        FuncionarioNivel3 funcionario3 = new FuncionarioNivel3();
        funcionario3.Nome = "Joana";

        System.Console.WriteLine($"Nome do funcionario: {funcionario1.Nome}, a sua participação é de {funcionario1.CalcularParticipacao()} reais");

        System.Console.WriteLine($"Nome do funcionario: {funcionario2.Nome}, a sua participação é de {funcionario2.CalcularParticipacao()} reais");

        System.Console.WriteLine($"Nome do funcionario: {funcionario3.Nome}, a sua participação é de {funcionario3.CalcularParticipacao()} reais");

    }
}