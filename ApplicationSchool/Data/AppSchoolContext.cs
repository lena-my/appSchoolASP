using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class AppSchoolContext : DbContext
{
    // constructor (added <AppSchooContext>)
    public AppSchoolContext(DbContextOptions<AppSchoolContext> options) : base(options)
    {
    }

    public DbSet<Student> Students { get; set; } // creates database students
    public DbSet<Course> Courses { get; set; } // creates database courses
}