using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class VendingMachine
{
    private Dictionary<Place, Product> Inventory { get; } = new();
    public CoinDispenser CoinDispenser { get; } = new();

    public void LoadProduct(Place place, Product product)
    {
        Inventory[place] = product;
    }

    public void UnloadProduct(Place place)
    {
        Inventory.Remove(place);
    }

    public bool BuyProduct(Place place, decimal amount)
    {
        if (Inventory.TryGetValue(place, out Product product))
        {
            if (product.Price <= amount)
            {
                if (CoinDispenser.CanMakeChange(amount - product.Price))
                {
                    CoinDispenser.AddCoins(new Coin(amount), 1);
                    return true;
                }
            }
        }
        return false;
    }

    public decimal CalculateTotalSales()
    {
        decimal totalSales = 0;
        foreach (var place in Inventory.Keys)
        {
            totalSales += Inventory[place].Price;
        }
        return totalSales;
    }

    public void ReplenishCoins(Dictionary<Coin, int> coins)
    {
        foreach (var coin in coins)
        {
            CoinDispenser.AddCoins(coin.Key, coin.Value);
        }
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