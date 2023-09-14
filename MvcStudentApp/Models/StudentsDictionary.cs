using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public class StudentsDictionary : IStudentProvider
{
    public List<Student> Students { get; }
    public Dictionary<long, Student> StudentsMarks { get; }

    public StudentsDictionary(List<Student> students, Dictionary<long, Student> studentsMarks)
    {
        Students = students;
        StudentsMarks = studentsMarks;
    }
}