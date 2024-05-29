using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers;
public class TeacherController : Controller
{
    public TeacherController()
    {
    }

    public IActionResult TeacherAdd()
    {
        return View();
    }
    public IActionResult TeacherSave()
    {
      return Redirect("ListOfTeachers");
    }

    public IActionResult ListOfTeachers()
    {
        TeachersModel teachers = new TeachersModel();
        teachers.name ="Ricardo Elizalde";
        teachers.profession ="computer systems engineer";
        teachers.tuition =0001;
        teachers.age=39;
        teachers.sex="M";

        TeachersModel teachers2 = new TeachersModel();
        teachers2.name ="David Corpus";
        teachers2.profession ="Licenciado en Matematicas";
        teachers2.tuition =0002;
        teachers2.age=51;
        teachers2.sex="M";

         List<TeachersModel> List = new List<TeachersModel>();
        List.Add(teachers);
        List.Add(teachers2);
        
        
        return View(List);
    }
    public IActionResult TeacherShowAndEdit()
    {
        return View();
    }

    public IActionResult TeacherEdit()
    {
        return Redirect("ListOfTeachers");
    }

    public IActionResult TeacherShowToDelete()
    {
        return View();
    }

    public IActionResult TeacherDelete()
    {
        //borra el registro 
        return Redirect("ListOfTeachers");
    }
}
