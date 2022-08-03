namespace FormularioInscricao;

public static class FormatacaoTexto
{
    public static string Formatacao(string nome, string curso, decimal valorCurso)
    {
        return $"Nome: {nome}| Curso: {curso}| Valor do Curso: {valorCurso}";
    }

    public static string Formatacao(string nome, string curso, decimal valorCurso, decimal valorDesconto)
    {
        return $"Nome: {nome}| Curso: {curso}| Valor do Curso: {valorCurso}| Valor do Desconto: {valorDesconto}";
    }

    public static string Formatacao(string nome, string curso, decimal valorCurso, decimal valorDesconto, int idade)
    {
        return $"Nome: {nome}| Idade: {idade}| Curso: {curso}| Valor do Curso: {valorCurso}| Valor do Desconto: {valorDesconto}";
    }
}