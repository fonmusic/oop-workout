using System.Threading.Channels;
using StudentApp.Models;

var s1 = new Student("Иван", 25);
var s2 = new Student("Игорь", 23);
var s3 = new Student("Иван", 22);

var s4 = new Student("Игорь", 18);
var s5 = new Student("Даша", 23);
var s6 = new Student("Лена", 20);
var s7 = new Student("Игорь", 19);

var s8 = new Student("Даша", 22);
var s9 = new Student("Лена", 21);



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
    s7
};

var students3 = new List<Student>
{
    s8,
    s9,
};

var group5123 = new StudentGroup(students1, 5123);
var group5124 = new StudentGroup(students2, 5124);
var group5125 = new StudentGroup(students3, 5125);

var stream = new StudentStream(new List<StudentGroup>
{
    group5125,
    group5124,
    group5123,
});

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Unsorted stream with unsorted groups:");
Console.WriteLine(stream);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("We sort all students in each group by age:");
foreach (var group in stream)
{
    group.Sort();
}
Console.WriteLine(stream);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("We sort all groups by number of students:");
stream.Sort();
Console.WriteLine(stream);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("We sort all groups by group id:");
stream.SortById();
Console.WriteLine(stream);
