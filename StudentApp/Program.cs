using StudentApp.Models;

var s1 = new Student("Иван", 25);
var s2 = new Student("Игорь", 23);
var s3 = new Student("Иван", 22);

var s4 = new Student("Игорь", 23);
var s5 = new Student("Даша", 23);
var s6 = new Student("Лена", 23);

var s7 = new Student("Игорь", 21);
var s8 = new Student("Даша", 22);
var s9 = new Student("Лена", 23);

var students1 = new List<Student>
{
    s1,
    s2,
    s3,
};

var students2 = new List<Student>
{
    s4,
    s5,
    s6,
};

var students3 = new List<Student>
{
    s7,
    s8,
    s9,
};

var group5123 = new StudentGroup(students1, 5123);
var group5124 = new StudentGroup(students2, 5124);
var group5125 = new StudentGroup(students3, 5125);

Console.WriteLine(group5123);

group5123.Sort();

foreach (var student in group5123)
{
    Console.WriteLine(student);
}