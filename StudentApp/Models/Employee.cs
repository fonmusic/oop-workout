namespace StudentApp.Models;

public class Employee : Person<string>
{
    public string Profession { get; private set; }

    public Employee(string name, int age, string info) : base(name, age, info)
    {
        Profession = info;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, Profession: {Profession}";
    }
}