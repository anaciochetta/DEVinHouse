namespace Empresa;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();
        funcionario.Nome = "Cláudia";
        funcionario.Id = 60;
        funcionario.DataNascimento = new DateTime(2013, 6, 1, 12, 32, 30);
        funcionario.SalvarNomeFuncionario();

        Console.WriteLine("");
        Console.WriteLine($"Salário: {funcionario.Salario}");
        Console.WriteLine($"Aplicando reajuste de 50%");
        funcionario.ReajusteConvensaoColetiva(50);
        Console.WriteLine($"Salário com reajuste: {funcionario.Salario}");
        Console.WriteLine("");


        CentroDeCusto centroDeCusto = new CentroDeCusto(1, "TESTE", DateTime.Now, 10M, 2022);

        Departamento departamento = new Departamento(centroDeCusto);
        departamento.Id = 100;
        departamento.DescricaoDepartamento = "DevInHouse";
        departamento.CentroDeCusto = new Random(50).Next(5000);
        departamento.FuncionarioNoDepartamento = funcionario;


        departamento.InserirFuncionarioNoDepartamento();

        Pagamento pagamentoEfetuadoSucesso = new Pagamento(1500, 100, ETipoFuncionario.PJ, DateTime.Now.AddDays(15));
        // DateTime.Now.AddDays(15) pega o dia de hoje e adciona mais 15 dias
        //pagamento.Valor = 12M; não pode pois a propiedade está com o set private

        pagamentoEfetuadoSucesso.TipoFuncionario = ETipoFuncionario.Autonomo;
        pagamentoEfetuadoSucesso.EfetuarCalculo();

        //simular o erro do pagamento
        Pagamento pagamentoEfetuadoErro = new Pagamento(3000, 5900, ETipoFuncionario.PJ, DateTime.Now);

        pagamentoEfetuadoErro.TipoFuncionario = ETipoFuncionario.PF;
        pagamentoEfetuadoErro.EfetuarCalculo();

        //sobrecarga
        Funcionario funcionario2 = new Funcionario();
        funcionario2.Id = 60;
        funcionario2.DataNascimento = new DateTime(2013, 6, 1, 12, 32, 30);
        funcionario2.SalvarNomeFuncionario();
        funcionario2.DadosFuncionario("Marcelo", "Camelo");
        funcionario2.DadosFuncionario("Marcelo", "Camelo", DateTime.Now.AddYears(-37));
        // DateTime.Now.AddDays(-37) pega o dia de hoje e tira 37 anos


    }
}