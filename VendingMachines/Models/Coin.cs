namespace VendingMachines.Models;

public class Coin
{
    public decimal Value { get; }

    public Coin(decimal value)
    {
        Value = value;
    }
    
    public override string ToString()
    {
        return $"{Value} usd";
    }
}