namespace VendingMachines.Models;

public class HotDrink : Product
{
    private readonly int _temperature;
    
    public HotDrink(string name, decimal price, int temperature) : base(name, price)
    {
        _temperature = temperature;
    }
    
    public override string ToString()
    {
        return $"{Name} - {_temperature} C - {Price} usd";
    }

}