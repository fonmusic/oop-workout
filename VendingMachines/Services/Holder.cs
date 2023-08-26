using VendingMachines.Models;

namespace VendingMachines.Services;

public class Holder
{
    public List<Place?> Places { get; }

    public Holder(int rows, int columns)
    {
        Places = new List<Place?>();
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                Places.Add(new Place(i, j, true));
            }
        }
    }
    
    public Place? GetFreePlace()
    {
        return Places.FirstOrDefault(p => p.IsFree);
    }
}