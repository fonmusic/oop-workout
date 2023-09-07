using StudentApp.Models;

namespace StudentApp.Services;

public class StudentService : IPersonService<Student>
{
    private readonly List<Student> _students = new();

    public List<Student> GetAll()
    {
        return _students;
    }

    public void Create(string name, int age, PersonInfo<string> info)
    {
        _students.Add(new Student(name, age, info.Value));
    }
    
}
 