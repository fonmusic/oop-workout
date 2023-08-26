namespace VendingMachines.Services;

public class CoinDispenser
{
    public Dictionary<int, int> CoinInventory { get; private set; } // coin value, number of coins
    
    public CoinDispenser(Dictionary<int, int> coinInventory)
    {
        CoinInventory = coinInventory;
    }

    public Dictionary<int, int> Dispense(int changeAmount)
    {
        var changeCoins = new Dictionary<int, int>();

        foreach (var coin in CoinInventory.Keys)
        {
            var numCoins = Math.Min(changeAmount / coin, CoinInventory[coin]);
            if (numCoins > 0)
            {
                changeCoins.Add(coin, numCoins);
                changeAmount -= numCoins * coin;
                CoinInventory[coin] -= numCoins;
            }

            if (changeAmount == 0)
                break;
        }

        if (changeAmount > 0)
        {
            throw new Exception("Not enough coins to dispense change");
            
        }

        return changeCoins;
    }
    
    public void RefillCoins(Dictionary<int, int> additionalCoins)
    {
        foreach (var coin in additionalCoins.Keys)
        {
            if (CoinInventory.ContainsKey(coin))
                CoinInventory[coin] += additionalCoins[coin];
            else
                CoinInventory.Add(coin, additionalCoins[coin]);
        }
    }
}