namespace MvcStudentApp.Models;

public class StudentsList : IStudentsList
{
    public List<Student> Students { get; private set; }
    
    public StudentsList(List<Student> students)
    {
        Students = students;
    }
}