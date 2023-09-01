namespace VendingMachines.Models;

public class Place
{
    public int Id { get; }
    public int Capacity { get; set; }
    public Product? Product { get; private set; }
    public int ProductCount { get; private set; }
    public string Label => Product?.ToString() ?? "empty";

    public Place(int id, int capacity)
    {
        Id = id;
        Capacity = capacity;
        ProductCount = 0;
    }
    
    public void AddProduct(Product product)
    {
        if (Product == null)
        {
            Product = product;
            ProductCount++;
        }
        else if (Product.Name == product.Name)
        {
            ProductCount++;
        }
    }

    public void RemoveProduct()
    {
        if (ProductCount <= 0) return;
        ProductCount--;
        if (ProductCount == 0)
        {
            Product = null;
        }
    }
    
    
    public override string ToString()
    {
        return $"Place {Id}: {Label} ({ProductCount} pcs)";
    }
}