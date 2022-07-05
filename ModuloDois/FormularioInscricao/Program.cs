namespace FormularioInscricao;

class Program
{
    static void Main(string[] args)
    {
        FormatacaoFormulario.Init();
    }
}

/* Se desconto for maior que zero utilizar **Formatação 2**
Se desconto for igual que zero utilizar **Formatação 1**
Se desconto for maior que zero e idade menor que 18 anos utilizar  **Formatação 3** */