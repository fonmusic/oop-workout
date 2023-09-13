namespace MvcStudentApp.Models;

public class Student : Person
{
    public int Id { get; }
    private static int _generalId;
    

    public Student(string name, int age) : base(name, age)
    {
        Id = ++_generalId;
    }
    
    public override string ToString()
    {
        return $"Id: {Id}, {base.ToString()}";
    }
}