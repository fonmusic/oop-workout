using System.Globalization;

namespace SolidLibrary;

public class Employee
{
    private readonly string _name;
    private readonly DateTime _dob;
    private int _baseSalary;

    public Employee(string name, DateTime dob, int baseSalary)
    {
        _name = name;
        _dob = dob;
        _baseSalary = baseSalary;
    }

    public string GetEmpInfo()
    {
        return "name - " + _name + " , dob - " + _dob.ToString(CultureInfo.InvariantCulture);
    }
}

public class SalaryCalculator
{
    public int CalculateNetSalary(int baseSalary)
    {
        var tax = (int)(baseSalary * 0.25);
        return baseSalary - tax;
    }
}