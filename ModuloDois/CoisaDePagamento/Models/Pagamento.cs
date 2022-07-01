namespace AppPagamento.Models;

class Pagamento
{
    public Guid Id { get; set; }
    public DateTime DataPagamento { get; set; }
    public DateTime DataVencimento { get; set; }
    public decimal Valor { get; set; }
    public string Metodo { get; set; }
    public string Descricao { get; set; }

    public virtual void Pagar(decimal valor)
    {
        Valor = valor;
        DataPagamento = DateTime.Now;
        System.Console.WriteLine("Pagamento feito");
    } //virtual para poder alterar nas classes herdadas
}
