using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackAdemy.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexMonth()
        {
            return View();
        }

        public ActionResult IndexYear()
        {
            return View();
        }

        public ActionResult Help()
        {
            ViewBag.Message = "The admin help page.";

            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "View admin reports.";

            return View();
        }
        public ActionResult AddStudent()
        {
            ViewBag.Message = "Add a student to the database.";

            return View();
        }
        public ActionResult Logout()
        {
            ViewBag.Message = "You have successfully logged out.";

            return View();
        }
    }
}