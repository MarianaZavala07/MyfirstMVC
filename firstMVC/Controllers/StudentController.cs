using firstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstMVC.Controllers;

public class StudentController : Controller
{
    public StudentController()
    {
    }

    public IActionResult StudentAdd()
    {
        return View();
    }

    public IActionResult StudentSave()
    {
      return Redirect("StudentList");
    }
     public IActionResult StudentList()
    {
         StudentModel student = new StudentModel();
         student.name ="Mariana Zavala";
         student.profession =" Ing Tecnologie of software";
         student.age=18;
         student.tuition=44514;
         student.sex="F";

         StudentModel student2 = new StudentModel();
         student2.name ="Adrian Cavazos";
         student2.profession ="Licenciado En Economia";
         student2.age=22;
         student2.tuition=56321;
         student2.sex="M";

         StudentModel student3 = new StudentModel();
         student3.name ="Carlos Arevalo";
         student3.profession =" Ing Elictrisita";
         student3.age=27;
         student3.tuition=15082;
         student3.sex="M";
         
        List<StudentModel> List = new List<StudentModel>();
        List.Add(student);
        List.Add(student2);
        List.Add(student3);
        
        
        return View(List);
        
    }

    public IActionResult StudentShowAndEdit()
    {
        return View();
    }

    public IActionResult StudentEdit()
    {
        return Redirect("StudentList");
    }

    public IActionResult StudentShowToDeleted()
    {
        return View();
    }

    public IActionResult StudentDelete()
    {
        //borra el registro 
        return Redirect("StudentList");
    }
}
