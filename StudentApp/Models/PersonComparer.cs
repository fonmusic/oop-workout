namespace StudentApp.Models;

public class PersonComparer<T>: IComparer<T> where T: Person<string>
{
    public int Compare(T? x, T? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException();
        return string.Compare(x.Name, y.Name, StringComparison.Ordinal);
    }
}