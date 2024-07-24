using WebApplication1.Models;

namespace WebApplication1.Repository;

public class CourseRepository
{
    public static List<Course> _courses = new List<Course>()
    {
        new Course()
        {
            Id = 1,
            Name = "Math"
        },
        new Course()
        {
            Id = 2,
            Name = "History"
        }, 
        new Course()
        {
            Id = 3,
            Name = "Geography"
        },
    };
}