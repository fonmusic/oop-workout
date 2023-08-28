using System.Text;

namespace VendingMachines.Models;

public class Holder<T>
{
    public List<T> Inventory { get; } = new();
    
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