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

        public ActionResult Report(string student = null)
        {
            ViewBag.Message = "View admin reports.";

            // Checks if there is a student name passed in
            if (student != null)
                ViewData["student"] = student;
            // Otherwise assigns a suggestion to select a student name
            else
                ViewData["student"] = "Select a Student";
            return View();
        }
        
        public ActionResult Report_PDF()
        {
            ViewBag.Message = "Example Report PDF";

            return View();
        }

        public ActionResult ModifyStudent()
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