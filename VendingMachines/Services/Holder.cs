using System.Text;
using VendingMachines.Models;

namespace VendingMachines.Services;

public class Holder
{
    public Place[] Inventory { get; }

    public Holder(int numberOfPlaces, int capacity)
    {
        Inventory = new Place[numberOfPlaces];
        for (var i = 0; i < numberOfPlaces; i++)
        {
            Inventory[i] = new Place(i + 1, capacity);
        }
    }
    
    public void LoadProduct(Product product)
    {
        var place = Inventory.FirstOrDefault(p => p.Product == null || p.Product.Name == product.Name);

        if (place != null && place.ProductCount < place.Capacity)
        {
            place.AddProduct(product);
        }
        else
        {
            var message = place == null ? "No available place for loading the product." : "No available capacity for loading the product.";
            Console.WriteLine(message);
        }
    }
    
    public void UnloadProduct(Product product)
    {
        var place = Inventory.FirstOrDefault(p => p.Product != null && p.Product.Name == product.Name);

        if (place != null)
        {
            place.RemoveProduct();
        }
        else
        {
            Console.WriteLine($"No place found with {product.Name} to unload.");
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Products:");
        foreach (var product in Inventory)
        {
            sb.AppendLine($"{product}");
        }

        return sb.ToString();
    }
}