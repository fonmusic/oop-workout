using MvcStudentApp.Models;
using MvcStudentApp.Views;

namespace MvcStudentApp.Controllers;

public class StudentsController
{
    private readonly IStudentsList _studentsList;
    private readonly IStudentsView _studentsView;
    private List<Student> _students = new();
    
    public StudentsController(IStudentsList studentsList, IStudentsView studentsView)
    {
        _studentsList = studentsList;
        _studentsView = studentsView;
    }
    
    public void Update()
    {
        // MVP
        _students = _studentsList.Students;
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
            var inputCommand = _studentsView.GetCommand("Имеются команды: \n" +
                                                        "1. Read - прочитать всех студентов \n" +
                                                        "2. Exit - выход из программы \n" +
                                                        "Введите команду: ");
            inputCommand = inputCommand.ToLower();
            inputCommand = inputCommand.First().ToString().ToUpper() + inputCommand.Substring(1);
            var command = (Command)Enum.Parse(typeof(Command), inputCommand);
            switch (command)
            {
                case Command.Exit:
                    getNewIteration = false;
                    Console.WriteLine("Выход из программы");
                    break;
                case Command.Read:
                    _studentsView.PrintAllStudents(_studentsList.Students);
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
}