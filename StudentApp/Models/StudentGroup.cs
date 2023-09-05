using System.Collections;
using System.Text;

namespace StudentApp.Models;

public class StudentGroup : IEnumerable<Student>, IComparable<StudentGroup>
{
    public List<Student> Group { get; private set; }
    public int GroupId { get; private set; }

    public StudentGroup(List<Student> group, int groupId)
    {
        Group = group;
        GroupId = groupId;
    }


    public IEnumerator<Student> GetEnumerator()
    {
        // return Group.GetEnumerator();
        return new StudentEnumerator(Group);
    }

    public int CompareTo(StudentGroup? other)
    {
        // by number of students
        if (Group.Count > other!.Group.Count)
            return 1;
        if (Group.Count < other!.Group.Count)
            return -1;
        return 0;
    }
    
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append($"Group Id: {GroupId}, Count of students: {Group.Count}");
        sb.Append('\n');
        foreach (var student in Group)
        {
            sb.Append(student);
            sb.Append('\n');
        }
        sb.Append('\n');
        return sb.ToString();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Sort()
    {
        Group.Sort();
    }
}