using MvcStudentApp.Models;
using MvcStudentApp.Views;
using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Controllers;

public class StudentsController
{
    private readonly IStudentProvider _studentProvider;
    private readonly IStudentsView _studentsView;
    private List<Student> _students = new();
    
    public StudentsController(IStudentProvider studentProvider, IStudentsView studentsView)
    {
        _studentProvider = studentProvider;
        _studentsView = studentsView;
    }
    
    public void Update()
    {
        // MVP
        _students = _studentProvider.Students;
        if (IsStudentExists())
            _studentsView.PrintAllStudents(_students);
        else
            Console.WriteLine("No students found");

        // MVC
        // _studentsView.PrintAllStudents(_studentsList.Students);
    }
    
    public void Run()
    {
        var getNewIteration = true;
        while (getNewIteration)
        {
            var inputCommand = _studentsView.GetCommand();
            var command = (Command)Enum.Parse(typeof(Command), inputCommand);
            switch (command)
            {
                case Command.Exit:
                    getNewIteration = false;
                    Console.WriteLine(_studentsView is StudentsViewRu ? "Выход из программы" : "Exit from program");
                    break;
                case Command.Read:
                    _studentsView.PrintAllStudents(_studentProvider.Students);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
    
    private bool IsStudentExists()
    {
        return _students.Count > 0;
    }

    // private string GetEngOrRuMenu()
    // {
    //     if (_studentsView is StudentsViewRu)
    //         return "Имеются команды: \n" +
    //                "1. Read - прочитать всех студентов \n" +
    //                "2. Exit - выход из программы \n" +
    //                "Введите команду: ";
    //     return "Available commands: \n" +
    //            "1. Read - read all students \n" +
    //            "2. Exit - exit from program \n" +
    //            "Enter command: ";
    // }
}