using System.Collections;

namespace StudentApp.Models;

/// <summary>
/// Student stream enumerator.
/// </summary>
public class StudentStreamEnumerator : IEnumerator<StudentGroup>
{
    private List<StudentGroup> Stream { get; set; }
    private int _position = -1;
    public StudentStreamEnumerator(List<StudentGroup> stream)
    {
        Stream = stream;
    }

    public bool MoveNext()
    {
        _position++;
        return _position < Stream.Count;
    }

    public void Reset()
    {
        _position = -1;
    }

    public StudentGroup Current => Stream[_position];

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }
}