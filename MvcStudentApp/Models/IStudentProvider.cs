using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public interface IStudentProvider
{
    List<Student> Students { get; }
    
    void DeleteStudentById(long id);
    bool IsStudentExists(long studentId);
}