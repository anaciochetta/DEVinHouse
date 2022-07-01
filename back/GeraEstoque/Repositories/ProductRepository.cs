using GeraEstoque.Models;

namespace GeraEstoque.Repositories;

public class ProductRepository
{
    public IList<Product> ProductList; //propiedade da instância

    public ProductRepository()
    {
        ProductList = new List<Product>();
    }

}