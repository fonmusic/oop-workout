namespace StudentApp.Models;

public class PersonInfo<T>
{
    public T Value { get; set; }
    public PersonInfo(T value)
    {
        Value = value;
    }
}