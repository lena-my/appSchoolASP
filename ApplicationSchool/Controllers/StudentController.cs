using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository;

namespace WebApplication1.Controllers;

public class StudentController : Controller
{
    // GET
    public IActionResult List()
    {
        var students = StudentRepository.GetStudents();
        return View(students);
    }

    public IActionResult Edit(int idStudent)
    {
        var student = StudentRepository.GetStudentById(idStudent);

        if (student is null)
        {
            return View("List");
        }
        
        return View(student);
    }
}