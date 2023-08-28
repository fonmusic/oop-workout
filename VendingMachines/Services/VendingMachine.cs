using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class VendingMachine
{
    public Holder<Product> Holder { get; } = new();
    public CoinDispenser CoinDispenser { get; } = new();
    public decimal TotalSales { get; private set; }
    
    public void LoadProduct(Product product)
    {
        Holder.Inventory.Add(product);
    }
    
    private void UnloadProduct(Product product)
    {
        Holder.Inventory.Remove(product);
    }

    public bool BuyProduct(Product product, decimal amount)
    {
        if (!Holder.Inventory.Contains(product)) return false;
        if (product.Price > amount) return false;
        if (!CoinDispenser.CanMakeChange(amount - product.Price)) return false;
        UnloadProduct(product);
        TotalSales += product.Price;
        return true;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Vending Machine:");
        sb.AppendLine(Holder.ToString());
        sb.AppendLine(CoinDispenser.ToString());
        return sb.ToString();
    }
}