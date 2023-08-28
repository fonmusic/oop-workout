using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class VendingMachine
{
    private Dictionary<Place, Product> Inventory { get; } = new();
    public CoinDispenser CoinDispenser { get; } = new();
    public decimal TotalSales { get; private set; }

    public void LoadProduct(Place place, Product product)
    {
        Inventory[place] = product;
    }

    private void UnloadProduct(Place place)
    {
        Inventory.Remove(place);
    }

    public bool BuyProduct(Place place, decimal amount)
    {
        if (!Inventory.TryGetValue(place, out var product)) return false;
        if (product.Price > amount) return false;
        if (!CoinDispenser.CanMakeChange(amount - product.Price)) return false;
        UnloadProduct(place);
        TotalSales += product.Price;
        return true;
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Products:");
        foreach (var place in Inventory.Keys)
        {
            sb.AppendLine($"{place} : {Inventory[place]}");
        }
        sb.AppendLine(CoinDispenser.ToString());
        return sb.ToString();
    }
 
}