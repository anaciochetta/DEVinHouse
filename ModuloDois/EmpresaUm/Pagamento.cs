namespace Empresa;

public class Pagamento
{
    //Propriedades Públicas 
    //com o private set, somente a classe altera o conteúdo
    public decimal Valor { get; private set; }
    public int IdFuncionario { get; private set; }
    //pode ser alterado fora da classe de pagamento
    public ETipoFuncionario TipoFuncionario { get; set; }

    //Propriedades Privadas (para encapsulamento da classe pagamento)
    private decimal CalcularPercentualDeDesconto { get; set; }
    private decimal SaldoInicial { get; set; }
    private decimal SaldoComDesconto { get; set; }
    private DateTime DataPagamento { get; set; }

    //Construtor
    public Pagamento(decimal valor, int idFuncionario, ETipoFuncionario tipoFuncionario, DateTime dataPagamento)
    {
        Valor = valor;
        IdFuncionario = idFuncionario;
        TipoFuncionario = tipoFuncionario;
        DataPagamento = dataPagamento;
    }

    //Método que vai executar os métodos privados da classe pagamento
    public void EfetuarCalculo()
    {
        //data de pagamento for menor que o dia 15 do mês é efetuado o pagamento
        //data de pagamento for maior que o dia 15 do mês não é efetuado o pagamento
    }

    private void SimularConsultaBancoDadosParaSaldoInicial()
    {
        //buscando informação em um banco de dados - tipo select
        SaldoInicial = 1500M;
    }

    private void SimularConsultaBancoDadosParaSaldoComDesconto()
    {
        SaldoComDesconto = 10M;
    }
}

public enum ETipoFuncionario //enum são estáticos - poder ser eTipoFuncionario ou EnumTipoFuncionario
{
    PF = 99,
    PJ = 100,
    Autonomo = 1001
}