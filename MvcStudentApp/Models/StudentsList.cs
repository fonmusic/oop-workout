using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public class StudentsList : IStudentProvider
{
    public List<Student> Students { get; }
    public void DeleteStudentById(long id)
    {
        Students.RemoveAll(s => s.Id == id);
    }

    public bool IsStudentExists(long studentId)
    {
        return Students.Any(s => s.Id == studentId);
    }

    public StudentsList(List<Student> students)
    {
        Students = students;
    }
}