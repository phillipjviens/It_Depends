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

        public ActionResult Help()
        {
            ViewBag.Message = "Your Help page.";

            return View();
        }

        public ActionResult Report()
        {
            ViewBag.Message = "Your report page.";

            return View();
        }
        public ActionResult AddStudent()
        {
            ViewBag.Message = "add Student page.";

            return View();
        }
        public ActionResult Logout()
        {
            ViewBag.Message = "Your logout page.";

            return View();
        }
    }
}