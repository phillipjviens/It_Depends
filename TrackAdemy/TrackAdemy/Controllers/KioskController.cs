using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackAdemy.Controllers
{
    public class KioskController : Controller
    {
        /// <summary>
        /// simple index page for the kiosk
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
  
    }
}