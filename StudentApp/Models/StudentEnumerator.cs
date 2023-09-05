using System.Collections;

namespace StudentApp.Models;

public class StudentEnumerator : IEnumerator<Student>
{
    public List<Student> Group { get; private set; }
    private int _position = -1;
    public StudentEnumerator(List<Student> group)
    {
        Group = group;
    }

    public bool MoveNext()
    {
        _position++;
        return _position < Group.Count;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    public Student Current => Group[_position];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
        // throw new NotImplementedException();
    }
}