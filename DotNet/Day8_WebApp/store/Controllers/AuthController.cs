using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using store.Models;
using SERIAL;
using System.Collections.Generic;

namespace store.Controllers;

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

    public IActionResult Validate(string email, string password)
    {
        //check email and password correct or not
        Serialize s1 = new Serialize();
        bool ul = s1.login(email, password);
        if (ul)
        {
            return Redirect("/Auth/Welcome");
        }
        else
            return Redirect("/Auth/Register");
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Postregister(
        string firstname,
        string lastname,
        int contactnumber,
        string email,
        string password
    )
    {
        Serialize s1 = new Serialize();
        bool ru = s1.register(firstname, lastname, contactnumber, email, password);
        //if user is created then return to login page ...alert to user succes and go to login
        if (ru)
        {
            return Redirect("/Auth/login");
        }
        //if user is not created then user is already exists ...alert to user fail and go to login
        else
        {
            return Redirect("/Auth/login");
        }
    }

    public IActionResult Welcome()
    {
        return View();
    }
}
