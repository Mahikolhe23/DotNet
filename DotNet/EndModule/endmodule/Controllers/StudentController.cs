using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using endmodule.Models;
using BLL;

namespace endmodule.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Portal()
    {
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }
    public IActionResult Display()
    {

        
        return View();
    }



    [HttpPost]
    public IActionResult Insert(int roll, string name, string email, string city)
    {
        StudentBLL std = new StudentBLL();
        bool ans = std.Insert(roll, name, email, city);
        Console.WriteLine(ans);
        if (ans)
            return Redirect("/Home/Index");
        return View();
    }
}
