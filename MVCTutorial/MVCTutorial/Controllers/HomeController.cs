using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\kent\Desktop\Bootcamp1\GitHub\log3.txt", text);
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("hello");
            //return RedirectToAction("Contact");

            //List<string> names = new List<string>()
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};


            //return View(names); // return View(); Will look for the Index() build;

            //int number = 5;
            //return View(number);
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;
            return View(user);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact()/*(int id=0) will add a zero to the end of the URL*/ 
        {
            //ViewBag.Message = id;

            return View();
        }
    }
}