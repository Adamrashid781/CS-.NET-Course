using Microsoft.AspNetCore.Mvc;

namespace TechAcadStudentMVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
