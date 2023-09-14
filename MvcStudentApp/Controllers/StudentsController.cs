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
                case Command.Delete:
                    var studentId = _studentsView.GetStudentId();
                    if (_studentProvider.IsStudentExists(studentId))
                        _studentProvider.DeleteStudentById(studentId);
                    else
                        Console.WriteLine(_studentsView is StudentsViewRu ? "Студент не найден" : "Student not found");
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
}