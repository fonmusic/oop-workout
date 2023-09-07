using StudentApp.Models;

namespace StudentApp.Services;

public class EmployeeService: IPersonService<Employee>
{
    private int _count;
    private readonly List<Employee> _employees = new();
    
    public List<Employee> GetAll()
    {
        return _employees;
    }

    public void Create<T1>(string name, int age, T1 info)
    {
        if (info is not null)
            _employees.Add(new Employee(name, age, info.ToString() ?? throw new InvalidOperationException()));
        _count++;
    }
    
    public void SortByNames()
    {
        var personComparer = new PersonComparer<Employee>();
        _employees.Sort(personComparer);
    }
}