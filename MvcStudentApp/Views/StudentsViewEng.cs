using MvcStudentApp.Models;
using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Views;

public class StudentsViewEng : IStudentsView
{
    public void PrintAllStudents(IEnumerable<Student> students)
    {
        Console.WriteLine("-----------List of students-----------:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("---------------------------------------");
    }

    public string GetCommand()
    {
        ShowMenuEn();
        
        var command = Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException();
        return string.Concat(command.First().ToString().ToUpper(), command.AsSpan(1));
    }

    private static void ShowMenuEn()
    {
        Console.Write("Available commands: \n" +
                      "1. Read - read all students \n" +
                      "2. Exit - exit from program \n" +
                      "Enter command: ");
    }
}