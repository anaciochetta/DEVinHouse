namespace AppPagamento.Models;

class PagamentoBoleto : Pagamento
{
    public string Numero { get; set; }

    public override void Pagar(decimal valor)
    {
        if (DataVencimento < DateTime.Now)
        {
            System.Console.WriteLine("Não é possível pagar um boleto vencido!");
        }
        else
        {
            base.Pagar(valor); //chama o método da classe do pagamento

        } //override -> sobrescrever o método herdado
    }
}
