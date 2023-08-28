namespace VendingMachines.Models;

public class Place
{
    private readonly int _row;
    private readonly ProductType _category;

    public Place(int row, ProductType category)
    {
        _row = row;
        _category = category;
    }
    
    public override string ToString()
    {
        return $"row: {_row}, category: {_category}";
    }
}