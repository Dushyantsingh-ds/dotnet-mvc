using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Mvc_Model.Models;

namespace Mvc_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Student stdnt = new Student()
            {
                Id = 01,
                Name = "Dev",
                Class = "B.Tech",
                City = "Mathura"
            };
            return View(stdnt);
        }
    }
}