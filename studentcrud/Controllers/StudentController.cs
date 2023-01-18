using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using studentcrud.Models;
using BLL;
using BOL;
namespace studentcrud.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult List()
    {
        
        StudentManager sm=new StudentManager();
        List<Student> sl=sm.GetStudentsData();
        this.ViewData["List"]=sl;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
