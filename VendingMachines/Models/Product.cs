namespace VendingMachines.Models;

public class Product
{
    protected string Name { get; }
    public decimal Price { get; }
    public Place Place { get; }

    public Product(string name, decimal price, Place place)
    {
        Name = name;
        Price = price;
        Place = place;
    }

    public override string ToString()
    {
        return $"{Name} - {Price} usd | {Place}";
    }
}