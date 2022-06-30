using GeraEstoque.Screens;
using GeraEstoque.Repositories;
namespace GeraEstoque;

class Program
{
    static void Main(string[] args)
    {
        ProductRepository repository = new ProductRepository();

        MenuScreen.Init(repository);

    }
}