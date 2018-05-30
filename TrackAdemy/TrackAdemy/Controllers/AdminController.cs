using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackAdemy.Controllers
{
    public class AdminController : Controller
    {
        /// <summary>
        /// Admin home view
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Index()
        {
            return View();
        }

       

        /// <summary>
        /// Shows the admin's help page
        /// </summary>
        /// <returns>View</returns>
        public ActionResult Help()
        {
            ViewBag.Message = "The admin help page.";

            return View();
        }

        /// <summary>
        /// Shows specific student report statistics
        /// </summary>
        /// <param name="student"></param>
        /// <param name="date"></param>
        /// <returns>View</returns>
        public ActionResult Report(string student = null, string date = null)
        {
            ViewBag.Message = "View admin reports.";

            // Checks if there is a student name passed in
            if (student != null)
                ViewData["student"] = student;
            // Otherwise assigns a suggestion to select a student name
            else
            {
                ViewData["student"] = "Select a Student";
                if (date != null)
                {
                    Console.WriteLine(date);
                    ViewData["timeRange"] = date;
                }
                else
                    ViewData["timeRange"] = "Current Week";
            }
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