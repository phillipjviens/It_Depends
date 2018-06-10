using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackAdemy.Backend;
using TrackAdemy.Models;

namespace TrackAdemy.Controllers
{

    public class HomeController : Controller
    {
        // A ViewModel used for the User that contains the UserList
        private StudentViewModel studentViewModel = new StudentViewModel();

        // The Backend Data source
        private StudentBackend studentBackend = StudentBackend.Instance;

        //GET: User
        /// <summary>
        /// Index, the page where the list will be checked against 
        /// the login to determine access level for the redirect
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            //studentViewModel.StudentList = studentBackend.Index();
            return View();  //userViewModel);
        }

        /// <summary>
        /// About page
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        /// <summary>
        /// the help page
        /// </summary>
        /// <returns></returns>
        public ActionResult Help()
        {
            ViewBag.Message = "Your Help page.";

            return View();
        }
        /// <summary>
        /// the error page
        /// </summary>
        /// <returns></returns>
        public ActionResult Error()
        {
            ViewBag.Message ="Error Page";
            return View();
        }
        
    }
}