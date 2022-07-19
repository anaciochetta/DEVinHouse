using System.Text.RegularExpressions;

namespace Semana5;

public static class ProgramaEmpresa
{
    public static void Init()
    {
        Ex5();
    }

    static void Ex5()
    {
        try
        {
            Console.WriteLine("Para criar um funcionário digite um nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("digite um id: ");
            string id = Console.ReadLine();

            EValidoNome(nome);
            ValidarRegexId(id);
            ValidarRegexNome(nome);

            Empregado empregado = new(int.Parse(id), nome);
            Console.WriteLine($"Funcionário: {empregado.Nome}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Mensagem de erro" + ex.Message);
        }

    }

    static void EValidoNome(string nome)
    {
        if (nome == null)
        {
            throw new NullReferenceException("O objeto é null");
        }
    }

    static void ValidarRegexNome(string nome)
    {
        Regex regexNome = new("[a-zA-z]");
        if (!regexNome.IsMatch(nome))
        {
            throw new NomeFuncionarioInvalidoException(nome);
        }
    }

    static void ValidarRegexId(string id)
    {
        Regex regexId = new("[0-9]");
        if (!regexId.IsMatch(id))
        {
            throw new NomeFuncionarioInvalidoException(id);
        }
    }
}

public class NomeFuncionarioInvalidoException : Exception
{
    public NomeFuncionarioInvalidoException() { }
    public NomeFuncionarioInvalidoException(string nome) : base(String.Format($"Nome do funcionário inválido: {nome}")) { }

}

public class IDFuncionarioInvalidoException : Exception
{
    public IDFuncionarioInvalidoException() { }
    public IDFuncionarioInvalidoException(int id) : base(String.Format($"Id do funcionário inválido: {id}")) { }

}