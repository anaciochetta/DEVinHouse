namespace Estudos;

class HerancaExemplo
{
    public class Pai
    {
        public virtual int CalcularCodigo()
        {
            return 15;
        }
    }

    public class Filha : Pai
    {

        public void MetodoHeranca()
        {
            this.CalcularCodigo();
            base.CalcularCodigo();
            CalcularCodigo();
        }
    }
}