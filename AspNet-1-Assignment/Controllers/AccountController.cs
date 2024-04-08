using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_1_Assignment.Controllers;

[Authorize]
public class AccountController : Controller
{
public IActionResult AccountDetails()
{
    return View();
}

}
