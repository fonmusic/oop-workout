using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public class StudentsDictionary : IStudentProvider
{
    public List<Student> Students { get; }

    public Dictionary<long, Student> StudentsJournal { get; } = new();

    public StudentsDictionary(List<Student> students)
    {
        Students = students;
        foreach (var student in Students)
        {
            StudentsJournal.Add(student.Id, student);
        }
    }

    public void DeleteStudentById(long id)
    {
        Students.RemoveAll(s => s.Id == id);
        StudentsJournal.Remove(id);
    }

    public bool IsStudentExists(long studentId)
    {
        return StudentsJournal.ContainsKey(studentId);
    }
}