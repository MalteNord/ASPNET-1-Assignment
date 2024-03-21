using Microsoft.AspNetCore.Mvc;
using AspNet_1_Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace AspNet_1_Assignment.Controllers;

public class AuthController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager) : Controller
{
    private readonly UserManager<UserEntity> _userManager = userManager;
    private readonly SignInManager<UserEntity> _signInManager = signInManager;

    #region Sign Up

    [HttpGet]

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task <IActionResult> SignUp(SignUpViewModel model)
    {
        if (ModelState.IsValid)
        {
            try 
            {
                if (!await _userManager.Users.AnyAsync(x => x.Email == model.Email))
                {
                    var userEntity = new UserEntity
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        UserName = model.Email

                    };

                    var result = await _userManager.CreateAsync(userEntity, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("SignIn", "Auth");
                    }
                    else
                    {
                        ViewData["StatusMessage"] = "Something went wrong. Please try again.";
                    }
                }
                else
                {
                    ViewData["StatusMessage"] = "User with the same email address already exists.";
                }
            } catch {}
            
        }
        return View(model);
    }

    #endregion

    #region Sign In

    [HttpGet]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(SignInViewModel model)
    {
        try
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Account", "Auth");
                    }
                }
            }
            else
            {
                ViewData["StatusMessage"] = "Incorrect email or password.";
            }
        }catch{}
        return View(model);
    }

    #endregion

    #region Sign Out

    [HttpGet]

    public new async Task<IActionResult> SignOut()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("SignIn", "Auth");
    }

    #endregion

    #region Account

    public IActionResult Account()
    {
        return View();
    }

    #endregion
}