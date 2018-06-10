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
        /// The page for the student on site check in.  The student will click on their image,
        /// a green checkmark will appear when the student checks in.  When the student is ready
        /// to leave they will click their image and the checkmark will disappear.
        /// </summary>
        /// <returns>View of the kiosk page.</returns>
        public ActionResult Index()
        {
            return View();
        }
  
    }
}