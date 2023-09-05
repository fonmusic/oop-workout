using System.Collections;

namespace StudentApp.Models;

public class StudentStream : IEnumerable<StudentGroup>
{
    public List<StudentGroup> Stream { get; private set; }
    
    public StudentStream(List<StudentGroup> stream)
    {
        Stream = stream;
    }

    public IEnumerator<StudentGroup> GetEnumerator()
    {
        // return Stream.GetEnumerator();
        return new StudentStreamEnumerator(Stream);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public void Sort()
    {
        Stream.Sort();
    }
    
    public void SortById()
    {
        Stream.Sort((group1, group2) => group1.GroupId.CompareTo(group2.GroupId));
    }
    
    public override string ToString()
    {
        return $"Stream: {string.Join(", ", Stream)}";
    }
}