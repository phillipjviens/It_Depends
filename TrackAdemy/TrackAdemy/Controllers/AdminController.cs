using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackAdemy.Models;
using TrackAdemy.Backend;

namespace TrackAdemy.Controllers
{
    public class AdminController : Controller
    {
        // Creates a list of Admin and Students
        //private UserViewModel userViewModel = new UserViewModel();

        // User backend data source.
        //private UserBackend userBackend = UserBackend.Instance;


        /// <summary>
        /// Admin home view
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Shows specific student report statistics
        /// </summary>
        /// <param name="student"></param>
        /// <param name="date"></param>
        /// <returns>View</returns>
        public ActionResult Report(string id = null, string timeFrame = null)
        {
            return View();
        }

        /// <summary>
        /// Shows a PDF png of student data
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Report_PDF()
        {
            ViewBag.Message = "Example Report PDF";

            return View();
        }

        /// <summary>
        /// Modify's student data (name, picture(?), hours, deletes)
        /// </summary>
        /// <returns>View</returns>
        public ActionResult ManageStudent()
        {
            ViewBag.Message = "Manage a student in the database.";

            return View();
        }

        public ActionResult Calendar()
        {
            return View();
        }

    }
}