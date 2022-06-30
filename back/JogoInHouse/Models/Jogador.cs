namespace JogoInHouse.Models;

class Jogador : Personagem, IMovimento
{
    public Jogador(string nome, string classe)
    {
        Nome = nome;
        Classe = classe;

        PontosVida = 220;
        PontosAtaque = 15;
        PontosDefesa = 30;
        Nivel = 1;
    }
    public Jogador(string nome, string classe, int nivel)//sobrecarga de método
    {
        Nome = nome;
        Classe = classe;

        PontosVida = 220 * nivel;
        PontosAtaque = 15 * nivel;
        PontosDefesa = 30 * nivel;
        Nivel = nivel;
    }
    public void MoverEixoX()
    {
        throw new NotImplementedException();
    }

    public void MoverEixoY()
    {
        throw new NotImplementedException();
    }
}