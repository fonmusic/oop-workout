namespace VendingMachines.Models;

public class Bottle : Product
{
    private readonly double _volume;
    
    public Bottle(string name, decimal price, double volume) : base(name, price)
    {
        _volume = volume;
    }
    
    public override string ToString()
    {
        return $"{Name} - {_volume} ml - {Price} usd";
    }

}