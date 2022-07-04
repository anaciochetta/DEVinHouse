namespace Empresa;

class CentroDeCusto
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public DateTime DataCriacao { get; set; }
    public decimal VerbaLiberada { get; set; }
    public int AnoVerbaLiberada { get; set; }

    public CentroDeCusto(int id, string descricao, DateTime dataCriacao, decimal verbaLiberada, int anoVerbaLiberada)
    {
        Id = id;
        Descricao = descricao;
        DataCriacao = dataCriacao;
        VerbaLiberada = verbaLiberada;
        AnoVerbaLiberada = anoVerbaLiberada;
    }

    public void AlterarId(int id)//boa prática
    {
        Id = id;
    }

    public override string ToString() //método de log
    {
        var x = base.ToString(); //default da classe
        return $"Sobrescrita da classe CentroDeCusto {Id}|{Descricao}|{VerbaLiberada}";
    }
}