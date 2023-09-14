using MvcStudentApp.Models.Core;

namespace MvcStudentApp.Models;

public class StudentsFile : IStudentProvider
{
     private readonly string _fileName;

        public StudentsFile(string fileName)
        {
            _fileName = fileName;

            try
            {
                using (var sw = new StreamWriter(fileName, true))
                {
                    sw.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

        public void SaveAllStudentsToFile(List<Student> students)
        {
            try
            {
                using (var sw = new StreamWriter(_fileName, true))
                {
                    foreach (var student in students)
                    {
                        sw.WriteLine($"{student.Name} {student.Age} {student.Id}");
                    }
                    sw.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Student> Students
        {
            get
            {
                var students = new List<Student>();
                try
                {
                    using (var sr = new StreamReader(_fileName))
                    {
                        while (sr.ReadLine() is { } line)
                        {
                            var param = line.Split(' ');
                            if (param.Length < 2) continue;
                            var name = param[0];
                            if (!int.TryParse(param[1], out var age)) continue;
                            var student = new Student(name, age);
                            students.Add(student);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                return students;
            }
        }
}