namespace GeraEstoque;

public class Register
{
    public static void ProductRegister()
    {
        Console.Clear();
        Menu.DrawCanvas();

        ShowRegister();

    }

    static void ShowRegister()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Cadastro de produto");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        Console.SetCursorPosition(3, 5);
        Console.Write("Nome: ");
        string productName = Console.ReadLine();
        Console.SetCursorPosition(3, 6);
        Console.Write("Quantidade em estoque: ");
        var inventory = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 7);
        Console.Write("Valor de compra: ");
        var purchasePrice = short.Parse(Console.ReadLine());
        Console.SetCursorPosition(3, 8);
        Console.Write("Valor de venda: ");
        var salePrice = short.Parse(Console.ReadLine());

        SaveProduct(productName, inventory, purchasePrice, salePrice);
    }

    static void SaveProduct(string productName, short inventory, short purchasePrice, short salePrice)
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Produto cadastrado com sucesso!");

        var id = Guid.NewGuid();
        Console.SetCursorPosition(3, 4);
        Console.WriteLine($"Id: {id}");
        Console.SetCursorPosition(3, 5);
        Console.Write($"Nome: {productName}");
        Console.SetCursorPosition(3, 6);
        Console.Write($"Quantidade em estoque: {inventory} unidades ");
        Console.SetCursorPosition(3, 7);
        Console.Write($"Valor de compra: {purchasePrice} reais");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine($"Valor de venda: {salePrice} reais");

        Console.SetCursorPosition(2, 12);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Menu.Show();
    }
}