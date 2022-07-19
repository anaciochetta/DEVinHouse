/* Criar uma classe para ser encapsulada chamada CobrarCurso.
Criar as propriedades com modificador privado
ValorCurso
ValorMulta
ValorDesconto */

namespace FormularioInscricao;

public class CobrarCurso
{
    public decimal ValorCurso { get; private set; }
    public decimal ValorMulta { get; private set; }
    public decimal ValorDesconto { get; private set; }
    public decimal Resultado { get; set; }

    public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
    {
        ValorCurso = valorCurso;
        ValorMulta = valorMulta;
        ValorDesconto = valorDesconto;
        Resultado = CalculaCurso(valorCurso, valorDesconto, valorMulta);
    }

    private decimal CalculaCurso(decimal valorCurso, decimal valorDesconto, decimal valorMulta)
    {
        decimal resultado;
        if (valorMulta > 0)
        {
            resultado = valorCurso + valorMulta;
            return resultado;
        }
        resultado = valorCurso - valorDesconto;
        return resultado;
    }
}

