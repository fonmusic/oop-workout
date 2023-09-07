using StudentApp.Models;

namespace StudentApp.Services;

public interface IPersonService<T>
{
    List<T> GetAll();
    void Create(string name, int age, PersonInfo<string> info);
}