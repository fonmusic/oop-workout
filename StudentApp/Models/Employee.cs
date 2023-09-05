namespace StudentApp.Models;

public class Employee : Person
{
    public string Profession { get; private set; }

    public Employee(string name, int age, string profession) : base(name, age)
    {
        Profession = profession;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, Profession: {Profession}";
    }
}