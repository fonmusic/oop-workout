using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class VendingMachine
{
    private Holder Holder { get; }
    private CoinDispenser CoinDispenser { get; } = new();
    public decimal TotalSales { get; private set; }
    
    public VendingMachine(int numberOfPlaces = 10, int capacity = 10)
    {
        Holder = new Holder(numberOfPlaces, capacity);
    }
    
    public void LoadProduct(Product product)
    {
        Holder.LoadProduct(product);
    }
    
    private void UnloadProduct(Product product)
    {
        Holder.UnloadProduct(product);
    }
    
    public void BuyProduct(int placeId)
    {
        var place = Holder.Inventory.FirstOrDefault(p => p.Id == placeId);
        if (place?.Product == null)
        {
            Console.WriteLine($"{place?.Product} not found");
            return;
        }
        var product = place.Product;
        if (place.Product.Price > CoinDispenser.InputAmount)
        {
            Console.WriteLine("Not enough money");
            return;
        }
        if (!CoinDispenser.CanMakeChange(product.Price))
        {
            Console.WriteLine("Not enough coins for change");
            return;
        }
        UnloadProduct(place.Product);
        TotalSales += product.Price;
        CoinDispenser.InsertMoney(CoinDispenser.InputAmount - product.Price);
        Console.WriteLine($"Purchase successful! Get your {product.Name}!");
        Console.WriteLine($"Change: ${CoinDispenser.ChangeAmount}");
        CoinDispenser.ChangeAmount = 0;
    }
    
    public void AddCoins(Coin coin, int quantity)
    {
        CoinDispenser.AddCoins(coin, quantity);
    }
    
    public void InsertMoney(decimal amount)
    {
        CoinDispenser.InsertMoney(amount);
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Vending machine:");
        sb.AppendLine(Holder.ToString());
        sb.AppendLine(CoinDispenser.ToString());
        sb.AppendLine($"Total sales: ${TotalSales}");
        return sb.ToString();
    }
}