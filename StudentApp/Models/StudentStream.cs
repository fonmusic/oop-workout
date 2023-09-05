using System.Collections;
using System.Text;

namespace StudentApp.Models;

/// <summary>
/// Student stream is a collection of student groups.
/// </summary>
public class StudentStream : IEnumerable<StudentGroup>
{
    public List<StudentGroup> Stream { get; private set; }
    public int StreamId { get; private set; }
    public int NumberOfGroups { get; private set; }
    
    /// <summary>
    /// Constructor of student stream.
    /// In this constructor we calculate stream id and number of groups.
    /// </summary>
    /// <param name="stream">List of student groups.</param>
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
    
    /// <summary>
    /// Sorts all groups in the stream by number of students.
    /// </summary>
    public void Sort()
    {
        Stream.Sort();
    }
    
    /// <summary>
    /// Sorts all groups in the stream by group id.
    /// </summary>
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