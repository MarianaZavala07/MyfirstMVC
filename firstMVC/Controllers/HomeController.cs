using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstMVC.Models;

namespace firstMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult StudentList()
    {
         StudentModel alumn = new StudentModel();
         alumn.name ="Mariana Zavala";
         alumn.profession =" Ing Tecnologie of software";
         

        return View(alumn);
    }
    public IActionResult ListOfTeachers()
    {
        TeachersModel teacher = new TeachersModel();
        teacher.name ="Ricardo Elizalde";
        teacher.profession ="computer systems engineer";
        return View(teacher);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
