using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using endmodule.Models;
using BLL;
using BOL;

namespace endmodule.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    public IActionResult Portal()
    {
        return View();
    }
    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public IActionResult Login(string email,string password){
        UserBLL user= new UserBLL();
        bool ans= user.Login(email,password);
        if(ans)
            return Redirect("/Home/Index");
        return View();
    }
    public IActionResult Register(){
        return View();
    }

    [HttpPost]
    public IActionResult Register(string name,string email, string password){
        UserBLL user= new UserBLL();
        bool ans = user.Register(name,email,password);
        if(ans)
            return Redirect("/Home/Index");
        return View();    
    }
}