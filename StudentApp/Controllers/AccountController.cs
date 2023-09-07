using StudentApp.Models;

namespace StudentApp.Controllers;

public static class AccountController
{
    public static void PaySalary<T>(T person, int salary) where T : Teacher
    {
        Console.WriteLine($"Salary of {person.Name} is {salary}");
    }

    /// <summary>
    /// This method will calculate the average age of a list of persons
    /// </summary>
    /// <param name="persons"> List of persons </param>
    /// <typeparam name="T"> Type of person </typeparam>
    /// <returns> Average age of persons </returns>
    public static double AverageAge<T>(List<T> persons) where T : Person<string>
    {
        var sum = persons.Sum(person => person.Age);

        return (double)sum / persons.Count;
    }

}