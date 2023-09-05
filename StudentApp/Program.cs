using StudentApp.Models;

var s1 = new Student("Иван", 25);
var s2 = new Student("Игорь", 23);
var s3 = new Student("Иван", 22);
var s4 = new Student("Игорь", 23);
var s5 = new Student("Даша", 23);
var s6 = new Student("Лена", 23);

var students = new List<Student>
{
    s1,
    s2,
    s3,
    s4,
    s5,
    s6
};

var group5123 = new StudentGroup(students, 5123);

Console.WriteLine(group5123);

group5123.Sort();

foreach (var student in group5123)
{
    Console.WriteLine(student);
}