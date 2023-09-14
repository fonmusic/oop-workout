using MvcStudentApp.Models;
using MvcStudentApp.Models.Core;

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

    public string GetCommand()
    {
        ShowMenuRu();
        
        var command = Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException();
        return string.Concat(command.First().ToString().ToUpper(), command.AsSpan(1));
    }

    private static void ShowMenuRu()
    {
        Console.Write("Доступные команды: \n" +
                      "1. Read - прочитать всех студентов \n" +
                      "2. Exit - выход из программы \n" +
                      "Введите команду: ");
    }
    
    public long GetStudentId()
    {
        Console.Write("Введите id студента: ");
        var studentId = Console.ReadLine();
        return long.Parse(studentId ?? throw new InvalidOperationException());
    }
}