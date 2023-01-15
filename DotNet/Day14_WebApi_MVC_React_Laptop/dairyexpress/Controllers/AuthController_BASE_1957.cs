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
            return Redirect("/Home/index");
        return RedirectToAction("Login");
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
        return RedirectToAction("Login");
    }
}
