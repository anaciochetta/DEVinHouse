namespace JogoInHouse.Models;

public class Personagem : IAcao
{
    public double PontosVida;
    public double PontosAtaque;
    public double PontosDefesa;
    public string? Nome; //pode ser null por isso ?
    public string? Classe;
    public int Nivel;

    public void Atacar(Personagem alvo)//upcasting
    {
        alvo.Defender(PontosAtaque);
    }

    public void Defender(double pontosAtaque)
    {
        double dano = pontosAtaque > PontosAtaque ? pontosAtaque - PontosDefesa : 0;
        PontosVida -= dano;
    }
}