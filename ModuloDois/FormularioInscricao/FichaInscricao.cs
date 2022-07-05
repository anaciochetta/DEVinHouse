namespace FormularioInscricao;

public class FichaInscricao
{
    public string Nome { get; set; }
    public int Idade { get; }
    public DateTime DataNascimento { get; set; }
    public string Curso { get; set; }
    public string Escolaridade { get; set; }
    public decimal ValorCurso { get; set; }
    public decimal ValorDesconto { get; set; }
    public decimal ValorMulta { get; set; }

    public FichaInscricao(string nome, string curso, string escolaridade, decimal valorCurso, decimal valorDesconto, decimal valorMulta, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Curso = curso;
        Escolaridade = escolaridade;
        ValorCurso = valorCurso;
        ValorDesconto = valorDesconto;
        ValorMulta = valorMulta;
        Idade = CalcularIdade(dataNascimento);
    }

    private int CalcularIdade(DateTime dataNascimento)
    {
        int idade = DateTime.Now.Year - dataNascimento.Year;
        if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
        {
            idade = idade - 1;
        }
        return idade;
    }
}