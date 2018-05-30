using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackAdemy.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aspirations()
        {
            ViewBag.Message = "Your aspirations page.";

            return View();
        }

        public ActionResult Data()
        {
            ViewBag.Message = "Your Data page.";

            return View();
        }

        public ActionResult Logout()
        {
            ViewBag.Message = "Logout page.";

            return View();
        }
        public ActionResult Store()
        {
            ViewBag.Message = "Store page.";

            return View();
        }
        public ActionResult Yard()
        {
            ViewBag.Message = "Yard page.";

            return View();
        }
    }
}