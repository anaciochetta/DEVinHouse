using AppPagamento.Models;

namespace AppPagamento;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(DateTime.Now);
        var boleto = new PagamentoBoleto();
        boleto.DataVencimento = new DateTime(2022, 06, 14); //antiga
        boleto.Pagar(100M);

        var boleto2 = new PagamentoBoleto();
        boleto2.DataVencimento = new DateTime(2022, 07, 30); //futura
        boleto2.Pagar(100M);

        var pix = new PagamentoPix();
        pix.DataVencimento = new DateTime(2022, 07, 30);
        pix.Pagar(49.99M);

        //upcasting -> Pagamento umPagamento = new PagamentoBoleto();

        //downcasting PagamentoBoleto outroPagamento = (PagamentoBoleto)new Pagamento();
    }
}