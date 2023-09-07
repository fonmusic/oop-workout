using StudentApp.Models;

namespace StudentApp.Services;

/// <summary>
/// Teacher service class used to manage teachers.
/// </summary>
public class TeacherService : IPersonService<Teacher>
{
    private int _count;
    private readonly List<Teacher> _teachers = new();
    
    /// <summary>
    /// Gets the list of teachers.
    /// </summary>
    /// <returns>The list of teachers.</returns>
    public List<Teacher> GetAll()
    {
        return _teachers;
    }

    /// <summary>
    /// Creates a new teacher and adds it to the list of teachers.
    /// Also increments the count of teachers.
    /// </summary>
    /// <param name="name">The name of the teacher.</param>
    /// <param name="age">The age of the teacher.</param>
    /// <param name="info">The info of the teacher.</param>
    /// <typeparam name="T1">Note! This must be string.</typeparam>
    /// <exception cref="InvalidOperationException"></exception>
    public void Create<T1>(string name, int age, T1 info)
    {
        if (info is not null)
            _teachers.Add(new Teacher(name, age, info.ToString() ?? throw new InvalidOperationException()));
        _count++;
    }
    
    /// <summary>
    /// Sorts the list of teachers by names.
    /// </summary>
    private void SortByNames()
    {
        var personComparer = new PersonComparer<Teacher>();
        _teachers.Sort(personComparer);
    }
    
    /// <summary>
    /// Prints the list of teachers sorted by names.
    /// </summary>
    public void PrintSortedByNames()
    {
        SortByNames();
        foreach (var teacher in _teachers)
        {
            Console.WriteLine(teacher);
        }
    }
}