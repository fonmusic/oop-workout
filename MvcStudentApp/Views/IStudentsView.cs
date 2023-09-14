using MvcStudentApp.Models;
using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Views;

public interface IStudentsView
{
    void PrintAllStudents(IEnumerable<Student> students);
    string GetCommand();
    // string ShowMenu();
}