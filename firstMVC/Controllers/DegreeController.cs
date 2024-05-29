using System.Collections.Generic;
using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers;

public class DegreeController : Controller
{
    private readonly ILogger<DegreeController> _logger;
    public DegreeController(ILogger<DegreeController> logger)
    {
        _logger = logger;
    }

    public IActionResult DegreeAdd()
    {
        return View();
    }
    [HttpPost]
        public IActionResult DegreeSave(DegreModel degree)
    {
        if (!ModelState.IsValid)
        {
            _logger.LogInformation("el modelo no es valido");
            return View(degree);
        }

        
        _logger.LogInformation("el modelo es valiodo");
        

        return Redirect("DegreeList");
    }
    public IActionResult DegreeList()
    {

        _logger.LogInformation("Esto es un mensaje al cargar las carreras");
        
        //listado de objetos , se debe cambiar a que lea de base de datos*/
       
       //crear objetos de carrera
         DegreModel degree = new DegreModel();
        degree.name ="Ing Tecnologias de la informacion";

        DegreModel degree2 = new DegreModel();
        degree2.name ="Ing Mecanico Electrico";

        DegreModel degree3 = new DegreModel();
        degree3.name ="Ing TIndustrial Administrador";

       //objeto  de listas de carreras
        List<DegreModel> List = new List<DegreModel>();
        List.Add(degree);
        List.Add(degree2);
        List.Add(degree3);
        
        
        return View(List);
    }
    public IActionResult DegreeShowAndEdit()
    {
        return View();
    }
     [HttpPost]
    public IActionResult DegreeEdit()
    {
        return Redirect("DegreeList");
    }

    public IActionResult DegreeShowToDeleted()
    {
        return View();
    }
     [HttpPost]
    public IActionResult DegreeDelete()
    {
        //borra el registro 
        return Redirect("DegreeList");
    }
}
