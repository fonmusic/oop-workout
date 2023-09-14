using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public class StudentsList : IStudentProvider
{
    public List<Student> Students { get; }
    
    public StudentsList(List<Student> students)
    {
        Students = students;
    }
}