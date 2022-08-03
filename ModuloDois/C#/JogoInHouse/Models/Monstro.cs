namespace JogoInHouse.Models;

class Monstro : Personagem //extendendo o personagem ao monstro
{
    public Monstro(string nome, string classe)
    {
        Nome = nome;
        Classe = classe;

        PontosVida = 300;
        PontosAtaque = 12;
        PontosDefesa = new Random().Next(1, 8);//retorna um int entre 1 e 8
        Nivel = 1;
    }
}