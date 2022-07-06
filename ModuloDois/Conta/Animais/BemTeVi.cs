namespace Exercicios.Animais;

class BemTeVi : Ave
{
    public string TipoCanto { get; set; }

    public BemTeVi(string tipoCanto, string cor, string nome) : base(nome, cor)
    {
        TipoCanto = tipoCanto;
    }
}