namespace StudentApp.Models;

public class Teacher : Person
{
    public string AcademicDegree { get; private set; }
    
    public Teacher(string name, int age, string academicDegree) : base(name, age)
    {
        AcademicDegree = academicDegree;
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, AcademicDegree: {AcademicDegree}";
    }
}