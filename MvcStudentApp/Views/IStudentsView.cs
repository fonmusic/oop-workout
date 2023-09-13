using MvcStudentApp.Models;

namespace MvcStudentApp.Views;

public interface IStudentsView
{
    void PrintAllStudents(IEnumerable<Student> students);
    string GetCommand(string inputCommand);
}