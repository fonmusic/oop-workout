namespace StudentApp.Models;

public class Teacher : Person<string>
{
    public string AcademicDegree { get; private set; }

    public Teacher(string name, int age, string info) : base(name, age, info)
    {
        AcademicDegree = info;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, AcademicDegree: {AcademicDegree}";
    }
}