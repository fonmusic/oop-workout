namespace VendingMachines.Models;

public class Place
{
    private readonly int _row;
    private readonly int _column;

    public Place(int row, int column)
    {
        _row = row;
        _column = column;
    }
    
    public override string ToString()
    {
        return $"({_row}, {_column})";
    }
}