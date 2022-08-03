namespace JogoInHouse.Models;

public interface IAcao
{
    void Atacar(Personagem alvo)//upcasting 
    { }

    void Defender(double pontosAtaque) { }
}