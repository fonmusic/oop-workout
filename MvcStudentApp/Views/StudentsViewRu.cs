using MvcStudentApp.Models;

namespace MvcStudentApp.Views;

public class StudentsViewRu : IStudentsView
{
    public void PrintAllStudents(IEnumerable<Student> students)
    {
        Console.WriteLine("-----------Список студентов-----------:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("---------------------------------------");
    }

    public string GetCommand(string inputCommand)
    {
        Console.Write(inputCommand);
        return Console.ReadLine() ?? throw new InvalidOperationException();
    }
}