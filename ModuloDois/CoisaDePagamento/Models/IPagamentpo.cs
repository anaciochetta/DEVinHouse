namespace AppPagamento.Models;

public interface IPagamentos //precisa do I antes do nome por convenção
{
    static string Nome; //precisa ser estático ai não faz sentido
    void Pagar(decimal valor);
    void Estornar();
    decimal ConsultarSaldo();
}