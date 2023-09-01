using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class CoinDispenser
{
    private Dictionary<Coin, int> CoinInventory { get; } = new();
    public decimal InputAmount { get; private set; }
    public decimal ChangeAmount { get; set; }

    public void InsertMoney(decimal amount)
    {
        InputAmount += amount;
    }

    public void AddCoins(Coin coin, int quantity)
    {
        if (CoinInventory.ContainsKey(coin))
            CoinInventory[coin] += quantity;
        else
            CoinInventory.Add(coin, quantity);
    }

    // private void RemoveCoins(Coin coin, int quantity)
    // {
    //     if (CoinInventory.ContainsKey(coin))
    //     {
    //         if (CoinInventory[coin] >= quantity)
    //             CoinInventory[coin] -= quantity;
    //         else
    //             throw new Exception("Not enough coins");
    //     }
    //     else
    //         throw new Exception("Coin not found");
    // }

    public bool CanMakeChange(decimal productPrice)
    {
        var coins = CoinInventory.Keys.OrderByDescending(x => x.Value).ToList();
        var change = InputAmount - productPrice;
        foreach (var coin in coins)
        {
            while (change >= coin.Value && CoinInventory[coin] > 0)
            {
                change -= coin.Value;
                CoinInventory[coin]--;
                ChangeAmount += coin.Value;
            }
        }
        InputAmount = 0;
        return change == 0;
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