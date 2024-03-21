using Microsoft.AspNetCore.Mvc;

namespace AspNet_1_Assignment;

public class DefaultController : Controller
{

    [Route("/")]
    public IActionResult Home()
    {
        return View();
    }

}


