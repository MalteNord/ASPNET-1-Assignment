using AspNet_1_Assignment.Models;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace AspNet_1_Assignment;

public class DefaultController : Controller
{

    [Route("/")]
    public IActionResult Home()
    {
        return View();
    }
   

}


