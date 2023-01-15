using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dairyexpress.Models;
using BLL;  

namespace dairyexpress.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Postlogin(string email, string password)
    {
        Manager mgr = new Manager();
        if (mgr.validateBL(email, password))
<<<<<<< HEAD
            return Redirect("/Home/welcome");
        return RedirectToAction("Login");
=======
            return Redirect("/Home/Welcome");
        return RedirectToAction("Register");
>>>>>>> 4159ed38b96e28b7e8963aea9c42efb07bca3860
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult PostRegister(string name, string email, string password, int mobile)
    {
        Manager mgr = new Manager();
        if (mgr.RegisterBL(name, email, password, mobile))
            return Redirect("/Auth/Login");
        return RedirectToAction("Register");
    }
}
