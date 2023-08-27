using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class CoinDispenser
{
    private Dictionary<Coin, int> CoinInventory { get; } = new();
    public void AddCoins(Coin coin, int quantity)
    {
        if (CoinInventory.ContainsKey(coin))
            CoinInventory[coin] += quantity;
        else
            CoinInventory.Add(coin, quantity);
    }

    public void RemoveCoins(Coin coin, int quantity)
    {
        if (CoinInventory.ContainsKey(coin))
        {
            if (CoinInventory[coin] >= quantity)
                CoinInventory[coin] -= quantity;
            else
                throw new InvalidOperationException("Not enough coins to remove.");
        }
        else
            throw new KeyNotFoundException("Coin not found in inventory.");
    }
    
    public bool CanMakeChange(decimal amount)
    {
        foreach (var coin in CoinInventory.Keys.OrderByDescending(c => c.Value))
        {
            var maxCoins = (int)(amount / coin.Value);
            if (CoinInventory.TryGetValue(coin, out var availableCoins) && availableCoins >= maxCoins)
            {
                return true;
            }
        }
        return false;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Coin inventory:");
        foreach (var coin in CoinInventory.Keys)
        {
            sb.AppendLine($"{coin} - {CoinInventory[coin]}");
        }

        return sb.ToString();
    }
}