namespace VendingMachines.Models;

public class Product
{
    public string Name { get; private set; }
    public int Price { get; private set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price > 0 ? price : 10;
    }
    
    public override string ToString()
    {
        return $"{Name} - {Price} usd";
    }
}