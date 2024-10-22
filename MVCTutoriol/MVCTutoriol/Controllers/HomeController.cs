using MVCTutoriol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutoriol.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string text = "Hello";
            System.IO.File.WriteAllText(@"\\Mac\Home\Desktop\Log.txt", text);
            Random rnd = new Random(10);
            var num = rnd.Next();
            // RandomNumber is what holds the data from num and can be used in the index.cshtml file
            //ViewBag.RandomNumber = num; 
            //if (num > 20000)
            //{
            //    return View("About");
            //}

            List<string> names = new List<string>
            {
                "Jesse",
                "Adam",
                "Brett"
            };

            User user = new User();
            user.Id = 1;
            user.FirstName = "Adam";
            user.LastName = "Johnson";
            user.Age = 23; 


             return View(user);
            // return Content("Hello");
            // return RedirectToAction("Contact");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // throw new Exception("Invalid Page");
            return View();
            
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id; 
            // ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}