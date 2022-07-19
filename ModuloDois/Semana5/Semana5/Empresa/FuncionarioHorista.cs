namespace Semana5;

class FuncionarioHorista : Empregado
{
    public string Cnpj { get; set; }
    public Double Taxa { get; set; }

    public FuncionarioHorista(string cnpj, double taxa)
    {
        Cnpj = cnpj;
        Taxa = taxa;
    }

    void CalcularTaxas() { }
    void EmitirNota() { }
}