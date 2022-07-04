namespace Estudos;

class Abstracao
{
    public class MusicaExemplo
    {
        public bool Do { get; set; }
        public bool Re { get; set; }
        public bool Mi { get; set; }
        public bool Fa { get; set; }
        public bool Sol { get; set; }
        public bool La { get; set; }
        public bool Si { get; set; }
    }

    public class CifraExemplo
    {
        public bool NotalSol(MusicaExemplo musicaExemplo)
        {
            return musicaExemplo.Sol == true &&
                    musicaExemplo.Si == true &&
                    musicaExemplo.Re == true; //o acorde de sol é todas essas notas
            //== você compara
        }

        //código de cima é equivalente
        /* if (musicaExemplo.Sol == true & assim testa os outros antes de quebrar
                    musicaExemplo.Si == true && quando é dois se o primeiro for falso já quebra *usar esse*
                    musicaExemplo.Re == true;)
        {
            return true;
        }
        else
        {
            return false
        } */
    }

    //abstrair algo do mundo real e colocar em código
}