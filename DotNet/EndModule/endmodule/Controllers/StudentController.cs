using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using endmodule.Models;
using BLL;
using BOL;

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

    public IActionResult Display()
    {
        StudentBLL std= new StudentBLL();
        List<Student> list=std.Display();
        ViewData["display"]=list;
        return View();
    }
    public IActionResult Update()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Update(int rollno, string name, string email, string city)
    {
        StudentBLL std = new StudentBLL();
        std.Update(rollno, name, email, city);
        return Redirect("Display");
        
    }
    public IActionResult Insert()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Insert(int roll, string name, string email, string city)
    {
        StudentBLL std = new StudentBLL();
        bool ans = std.Insert(roll, name, email, city);
        if (ans)
            return RedirectToAction("Display");
        return View();
    }
    public IActionResult Detail(int id){
        StudentBLL std = new StudentBLL();
        Student s=std.GetStudentByRollNo(id);
        this.ViewData["student"]=s;
        return View();
    }
    public IActionResult Delete(int id){
        StudentBLL std = new StudentBLL();
        std.Delete(id);
        return RedirectToAction("Display");
    }
}
