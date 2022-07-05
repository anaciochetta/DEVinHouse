/* Criar uma classe para ser encapsulada chamada CobrarCurso.
Criar as propriedades com modificador privado
ValorCurso
ValorMulta
ValorDesconto */

namespace FormularioInscricao;

class CobrarCurso
{
    private decimal ValorCurso { get; set; }
    private decimal ValorMulta { get; set; }
    private decimal ValorDesconto { get; set; }
    public decimal Resultado { get; set; }

    public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto, decimal resultado)
    {
        ValorCurso = valorCurso;
        ValorMulta = valorMulta;
        ValorDesconto = valorDesconto;
        Resultado = CalculaCurso(valorCurso, valorDesconto, valorMulta);
    }

    private decimal CalculaCurso(decimal valorCurso, decimal valorDesconto, decimal valorMulta)
    {
        if (valorMulta == 0)
        {
            var resultado = valorCurso - valorDesconto;
            return resultado;
        }
        else if (valorMulta > 0)
        {
            var resultado = valorCurso + valorMulta;
            return resultado;
        }
    }
}

/* Criar um método da classe private para efetuar o calculo do curso preencher a propriedade Resultado da classe CobrarCurso

Se valor da multa for maior que zero não aplicar desconto

Resultado = Valor Curso + Valor Multa
Se valor da multa for igual a zero aplicar desconto

Resultado = Valor Curso - Valor Desconto
Atividade */
