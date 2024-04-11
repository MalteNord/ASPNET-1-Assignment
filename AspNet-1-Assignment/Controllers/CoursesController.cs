using Microsoft.AspNetCore.Mvc;

namespace AspNet_1_Assignment.Controllers;

public class CoursesController : Controller
{
    public IActionResult Courses()
    {
        return View();
    }
}
