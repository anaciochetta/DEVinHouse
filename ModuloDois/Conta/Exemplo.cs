namespace Exercicios;

public class Exemplo
{
    public static void TryCatch()
    {
        //tratamento de exceções - try e catch
        try
        {
            //código que  que pode disparar a exceção
            string texto = "10";  //erro poderia ser colocar "kkk" ou "0"
            int numero = Convert.ToInt32(texto);
            int resultado = 100 / numero;
            Console.WriteLine($"O resultado de 100 dividido por {numero} é {resultado}");
        }
        catch
        {
            //código que trata o "erro"/exceção (o plano de ação)
            Console.WriteLine("Valor informado é inválido");
        }
    }

    public static void TryCatchAvancado()
    {
        try
        {
            string texto = "kkk";
            int numero = Convert.ToInt32(texto);
            int resultado = 100 / numero;
            Console.WriteLine($"O resultado de 100 dividido por {numero} é {resultado}");
        }
        catch (FormatException ex1)
        {
            Console.WriteLine($"O formato de número informado é inválido, {ex1}");
        }
        catch (DivideByZeroException ex2)
        {
            Console.WriteLine($"O  número informado não pode ser dividido por zero, {ex2}");
        }
        //tratamento genérico
        catch (Exception ex)
        {
            Console.WriteLine($"A mensagem de exceção é: {ex}");
        }
    }

    //catch precisa ser organizado do mais específico para o mais genérico
}