namespace Empresa;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public decimal Salario { get; private set; }

    public Funcionario()
    {
        Salario = 1500M;
    }

    public void SalvarNomeFuncionario()
    {
        Console.WriteLine($"Salvo o nome: {Nome}");
        Console.WriteLine("");
    }

    public void ReajusteConvensaoColetiva(decimal percentual)
    {
        Salario += Salario * (percentual / 100);
    }

    //Sobrecarga
    //sem data de nascimento 
    public string DadosFuncionario(string primeiroNome, string segundoNome)
    {
        return $"Nome: {primeiroNome} {segundoNome}";
    }

    //com data de nascimento
    public string DadosFuncionario(string primeiroNome, string segundoNome, DateTime dataNascimento)
    {
        return $"{DadosFuncionario(primeiroNome, segundoNome)} | Data nascimento {dataNascimento}";
    }
}