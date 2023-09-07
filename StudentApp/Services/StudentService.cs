using StudentApp.Models;

namespace StudentApp.Services;

public class StudentService : IPersonService<Student>
{
    private readonly List<Student> _students = new();

    public List<Student> GetAll()
    {
        return _students;
    }

    public void Create<T1>(string name, int age, T1 info)
    {
        if (info is not null)
            _students.Add(new Student(name, age, info.ToString() ?? throw new InvalidOperationException()));
    }
}