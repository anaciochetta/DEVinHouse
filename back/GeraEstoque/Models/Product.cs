namespace GeraEstoque.Models;
class Product
{
    Guid Id;
    string ProductName;
    int Inventory;
    int PurchasePrice;
    int SalePrice;

    public Product() { }

    public Product(string name, int inventory, int purchasePrice, int salePrice)
    {
        Id = Guid.NewGuid();
        ProductName = name;
        Inventory = inventory;
        PurchasePrice = purchasePrice;
        SalePrice = salePrice;
    }

    public override string ToString()
    {
        string text = $"Produto: Id: {Id} |  Nome: {ProductName} | Qtd: {Inventory} | R$ Compra: {PurchasePrice} | R$ Venda: {SalePrice}";
        return text;
    }

}