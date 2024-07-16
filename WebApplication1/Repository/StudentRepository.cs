using WebApplication1.Models;
namespace WebApplication1.Repository;

public class StudentRepository
{
    private static List<Student> _students = new List<Student>()
    {
        new Student()
        {
            Id = 1,
            Name = "Bob",
            LastName = "Sponge"
        },
        new Student()
        {
            Id = 2,
            Name = "Patrick",
            LastName = "Star"
        },
        new Student()
        {
            Id = 3,
            Name = "Gary",
            LastName = "Snail"
        },
        new Student()
        {
            Id = 4,
            Name = "Sandy",
            LastName = "Cheeks"
        },
    };

    public static List<Student> GetStudents() => _students;

    public static void AddStudent(string name, string lastName)
    {
        var idNewStudent = _students.Max(x => x.Id);
        var newStudent = new Student()
        {
            Id = idNewStudent,
            Name = name,
            LastName = lastName
        };
        _students.Add(newStudent);
    }

    public static Student? GetStudentById(int idStudent)
    {
        var student = _students.Find(x => x.Id == idStudent);
        return student;
    }
}