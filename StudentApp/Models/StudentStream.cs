using System.Collections;
using System.Text;

namespace StudentApp.Models;

public class StudentStream : IEnumerable<StudentGroup>
{
    public List<StudentGroup> Stream { get; private set; }
    public int StreamId { get; private set; }
    public int NumberOfGroups { get; private set; }
    
    public StudentStream(List<StudentGroup> stream)
    {
        Stream = stream;
        StreamId = stream[0].GroupId / 100;
        NumberOfGroups = stream.Count;
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
        var sb = new StringBuilder();
        sb.Append($"Stream Id: {StreamId}, Count of groups: {NumberOfGroups}");
        sb.Append('\n');
        foreach (var group in Stream)
        {
            sb.Append(group);
        }
        sb.Append('\n');
        return sb.ToString();
    }
}