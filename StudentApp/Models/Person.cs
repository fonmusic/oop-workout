namespace StudentApp.Models;

public abstract class Person<T>
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public T Info { get; private set; }
    
    public Person(string name, int age, T info)
    {
        Name = name;
        Age = age;
        Info = info;
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Info: {Info}";
    }
}