using MvcStudentApp.Models;
using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Views;

/// <summary>
///  This class is a view in Russian language for students.
/// </summary>
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

    /// <summary>
    /// This method returns command from user.
    /// </summary>
    /// <returns>Command from user in string format with first letter in upper case.</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public string GetCommand()
    {
        ShowMenuEn();
        
        var command = Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException();
        return string.Concat(command.First().ToString().ToUpper(), command.AsSpan(1));
    }

    /// <summary>
    /// This method shows menu in English language.
    /// </summary>
    private static void ShowMenuEn()
    {
        Console.Write("Available commands: \n" +
                      "1. Read - read all students \n" +
                      "2. Delete - delete student by id \n" +
                      "3. Exit - exit from program \n" +
                      "Enter command: ");
    }

    /// <summary>
    /// This method returns student id from user.
    /// </summary>
    /// <returns>Student id from user in long format.</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public long GetStudentId()
    {
        Console.Write("Enter student id: ");
        var studentId = Console.ReadLine();
        return long.Parse(studentId ?? throw new InvalidOperationException());
    }
}