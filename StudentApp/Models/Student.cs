namespace StudentApp.Models;

public class Student : Person, IComparable<Student>
{
    public int Id { get; }
    private static int _generalId;
    
    public Student(string name, int age) : base(name, age)
    {
        Id = ++_generalId;
    }

    public int CompareTo(Student? other)
    {
        // by age
        if (Age > other!.Age)
            return 1;
        if (Age < other!.Age)
            return -1;
        return 0;
    }

    public override string ToString()
    {
        return $"Id: {Id}, {base.ToString()}";
    }
}