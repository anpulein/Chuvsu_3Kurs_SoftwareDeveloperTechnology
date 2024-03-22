using Microsoft.AspNetCore.Mvc;
using ShedStudyNew.ViewModels;

namespace ShedStudyNew.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AccountController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        var model = new LoginViewModel(); // Инициализация модели
        return View(model);
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        // if (ModelState.IsValid)
        // {
        //     // var result = 
        //     //     await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
        //     if (result.Succeeded)
        //     {
        //         // проверяем, принадлежит ли URL приложению
        //         if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
        //         {
        //             return Redirect(model.ReturnUrl);
        //         }
        //         else
        //         {
        //             return RedirectToAction("Index", "Home");
        //         }
        //     }
        //     else
        //     {
        //         ModelState.AddModelError("", "Неправильный логин и (или) пароль");
        //     }
        // }
        return View(model);
    }
}