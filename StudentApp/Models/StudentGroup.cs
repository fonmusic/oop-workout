using System.Collections;

namespace StudentApp.Models;

public class StudentGroup : IEnumerable<Student>
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

    public override string ToString()
    {
        // return $"GroupId: {GroupId}, \nGroup: {string.Join(", ", Group)}";
        return $"Group Id: {GroupId}";
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