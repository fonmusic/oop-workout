using MvcStudentApp.Controllers;
using MvcStudentApp.Models;
using MvcStudentApp.Views;

var students = new List<Student>
{
    new Student("John", 18),
    new Student("Jane", 19),
    new Student("Jack", 20),
    new Student("Jill", 21),
    new Student("James", 22),
    new Student("Judy", 23)
};

IStudentsList studentsList = new StudentsFile("students.csv");
//studentsList.SaveAllStudentsToFile(students);

// IStudentsList studentsList = new StudentsList(students);
IStudentsView studentsView = new StudentsViewRu();

var studentsController = new StudentsController(studentsList, studentsView);

// studentsController.Update();

studentsController.Run();