namespace Estudos;
public class Classe
{
    public static void ClasseExemplo()
    {
        var pagCartaoVisa = new Pagamento("VISA");

        pagCartaoVisa.Pagar(1500.25M);

        Console.WriteLine(pagCartaoVisa.Bandeira);
        Console.WriteLine(pagCartaoVisa.DataPagamento);
        Console.WriteLine(pagCartaoVisa.Valor);
        Console.WriteLine(pagCartaoVisa.Id);
    }

    //se fosse class Pagamento sairia somente VISA, mas no STRUCT sai os dois pois respeita o individualismo do objeto//
    class Pagamento
    {
        public string Bandeira = string.Empty; //s.e ao invés de ""
        public DateTime DataPagamento; //tipo complexo para dado 
        public Guid Id; //propiedade (prop snipet)
        private decimal ValorPago { get; set; }
        public decimal Valor
        {
            get { return ValorPago; }
            set { ValorPago = value >= 0 ? value : 0; } //se for menor que zero ele retorna 0
            //comportamento padrão para o get e set
        }

        //métodos dentro da classe
        public Pagamento(string bandeira) //construtor 
        {
            //Id = Guid.NewGuid();
            Bandeira = bandeira;
            System.Console.WriteLine("Criou uma instância");
        }
        public void Pagar(decimal valor)
        {
            ValorPago = valor;
            DataPagamento = DateTime.Now;
        }
    }


}

