namespace StudentApp.Models;

public abstract class Person<T>
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public PersonInfo<string> Info { get; private set; }
    
    public Person(string name, int age, string info)
    {
        Name = name;
        Age = age;
        Info = new PersonInfo<string>(info);
    }
    
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Info: {Info.Value}";
    }
}