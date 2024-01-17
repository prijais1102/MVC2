using Microsoft.AspNetCore.Mvc;
using MVC2.Models;

namespace MVC2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Priya";
            ViewBag.address = "Mzp";
            return View();
        }
        public ContentResult CheckContent()
        {
            return Content("Hi ! Priya");
        }
        public EmptyResult CheckEmptyResult()
        {
            return new EmptyResult();
        }
        public IActionResult Task2()
        {
            Student student = new Student { Name = "Preeti", Address = "Mzp" };
            return View(student);
        }

    }
}
//IActionResult
//Defines a contract that represents the result of an action method.
//ActionResult
//A default implementation of IActionResult.
//ContentResult
//Represents a text result.
//EmptyResult
//Represents an ActionResult that when executed will do nothing.
//JsonResult
//An action result which formats the given object as JSON.
//PartialViewResult
//Represents an ActionResult that renders a partial view to the response.
//ViewResult
//Represents an ActionResult that renders a view to the response.
//ViewComponentResult
//An IActionResult which renders a view component to the response.

