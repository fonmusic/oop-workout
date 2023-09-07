namespace StudentApp.Services;

public interface IPersonService<T>
{
    List<T> GetAll();
    void Create<T1>(string name, int age, T1 info);
}