using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class VendingMachine
{
    public Holder Holder { get; }
    public CoinDispenser CoinDispenser { get; }
    private List<Product> Products { get; }
    
    public VendingMachine(int rows, int columns, Dictionary<int, int> coinInventory)
    {
        Holder = new Holder(rows, columns);
        CoinDispenser = new CoinDispenser(coinInventory);
        Products = new List<Product>();
    }
    
    public void AddProduct(Product product)
    {
        Products.Add(product);
    }
    
    public Product GetProduct(string productName)
    {
        var product = Products.FirstOrDefault(p => p.Name == productName);
        if (product == null)
            throw new Exception("Product not found");
        
        Products.Remove(product);
        return product;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Products:");
        foreach (var product in Products)
        {
            sb.AppendLine(product.ToString());
        }
        
        return sb.ToString();
    }
}