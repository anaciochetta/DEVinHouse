using GeraEstoque.Repositories;

namespace GeraEstoque.Screens;

public static class ProductListScreen
{
    public static void Init(ProductRepository repository)
    {
        Console.Clear();

        ShowProductList(repository);
    }

    static void ShowProductList(ProductRepository repository)
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Lista de produtos cadastrados.");
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("---------------------------------");

        Console.SetCursorPosition(3, 5);

        foreach (var product in repository.ProductList)
        {
            Console.WriteLine(product.ToString());
        }



        Console.ReadKey();
    }
}