using MVCWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebApplication.Entity;

namespace MVCWebApplication.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            NorthwindEntities db_context = new NorthwindEntities();
            var _ulobj = db_context.UserLogins.Where(r => r.LoginID == model.Email && r.Password == model.Password).FirstOrDefault();
            if (_ulobj!=null)
            {
                Session["UserID"] = _ulobj.LoginID;
                return RedirectToAction("Index", "Home");
            }
          
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}