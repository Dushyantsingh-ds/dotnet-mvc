using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2_Rozer.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewBag_Def()
        {
            ViewBag.Name = "Dev";
            ViewBag.Class = "B.Tech";
            ViewBag.City = "Mathura"; 
            //label

            ViewBag.Array = new string[] {"India", "Usa", "Canada" };
            //Array

            ViewBag.List =new List<string>()
            {
                "Apple",
                "Mango",
                "Banana"
            };
            return View(); 
            // List
        }
        public ActionResult ViewData_Def()
        {
            ViewData["Name"] = "Dev";
            ViewData["Class"] = "B.Tech";
            ViewData["City"] = "Mathura";
            //label

            ViewData["Array"] = new string[] { "India", "Usa", "Canada" };
            //Array

            ViewData["List"] = new List<string>()
            {
                "Apple",
                "Mango",
                "Banana"
            };
            return View();
            // List
        }
        public ActionResult TempData_Def()
        {
            ViewBag.Name = "Dev";
            ViewBag.Class = "B.Tech";
            ViewBag.City = "Mathura";

            ViewData["Name"] = "Dev";
            ViewData["Class"] = "B.Tech";
            ViewData["City"] = "Mathura";

            TempData["Name"] = "Dev";
            TempData["Class"] = "B.Tech";
            TempData["City"] = "Mathura";


            return RedirectToAction("About");
        }
        public ActionResult About()
        {
            return View();
        }



    }
}