using StudentApp.Models;

namespace StudentApp.Services;

public class TeacherService : IPersonService<Teacher>
{
    private int _count;
    private readonly List<Teacher> _teachers = new();
    
    public List<Teacher> GetAll()
    {
        return _teachers;
    }

    public void Create<T1>(string name, int age, T1 info)
    {
        if (info is not null)
            _teachers.Add(new Teacher(name, age, info.ToString() ?? throw new InvalidOperationException()));
        _count++;
    }
    
    public void SortByNames()
    {
        var personComparer = new PersonComparer<Teacher>();
        _teachers.Sort(personComparer);
    }
    
    public void PrintSortedByNames()
    {
        SortByNames();
        foreach (var teacher in _teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}