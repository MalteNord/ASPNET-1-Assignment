using Microsoft.AspNetCore.Mvc;

namespace AspNet_1_Assignment.Controllers;

public class AccountController : Controller
{
[HttpGet]
public IActionResult AccountDetails()
{
    return View();
}

}
