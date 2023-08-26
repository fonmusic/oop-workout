namespace VendingMachines.Models;

public class Place
{
    public int Row { get; private set; }
    public int Column { get; private set; }
    public bool IsFree { get; set; }

    public Place(int row, int column, bool isFree)
    {
        this.Row = row;
        this.Column = column;
        this.IsFree = isFree;
    }
}