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
        // A ViewModel used for the Avatar that contains the AvatarList
        private UserViewModel userViewModel = new UserViewModel();

        // The Backend Data source
        private UserBackend userBackend = UserBackend.Instance;

        //GET: User
        public ActionResult Index()
        {
            userViewModel.UserList = userBackend.Index();            
            return View(userViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Your Help page.";
            
            return View();
        }
        //public ActionResult FormHandler(string username, int level)
        //{
        //    return RedirectToAction("Admin");
        //}
    }
}