using StudentApp.Models;

namespace StudentApp.Controllers;

public class AccountController
{
    public static void PaySalary<T>(T person, int salary) where T : Teacher
    {
        Console.WriteLine($"Salary of {person.Name} is {salary}");
    }

    public static double AverageAge<T>(List<T> persons) where T : Person<string>
    {
        var sum = persons.Sum(person => person.Age);

        return sum / persons.Count;
    }

}