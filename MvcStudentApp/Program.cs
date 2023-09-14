using MvcStudentApp.Controllers;
using MvcStudentApp.Models;
using MvcStudentApp.Models.Core;
using MvcStudentApp.Views;

var students = new List<Student>
{
    new("John", 18),
    new("Jane", 19),
    new("Jack", 20),
    new("Jill", 21),
    new("James", 22),
    new("Judy", 23)
};

// Work with list
// IStudentProvider studentProvider = new StudentsList(students);

// Work with dictionary
IStudentProvider studentProvider = new StudentsDictionary(students);

// Work with file
// var filePath = Path.Combine(Directory.GetCurrentDirectory(), "students.csv");
// StudentsFile studentsFile = new(filePath);
// studentsFile.SaveAllStudentsToFile(students);

// IStudentsView studentsView = new StudentsViewRu();

Console.WriteLine("Введите язык (ru/en): ");
var language = Console.ReadLine()?.ToLower();
IStudentsView studentsView = language switch
{
    "ru" => new StudentsViewRu(),
    "en" => new StudentsViewEng(),
    _ => throw new Exception("Неподдерживаемый язык")
};

// var studentsController = new StudentsController(studentsFile, studentsView);
var studentsController = new StudentsController(studentProvider, studentsView);

// studentsController.Update();

studentsController.Run();