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

        public ActionResult Error()
        {
            ViewBag.Message ="Error Page";
            return View();
        }
        /*
        //public ActionResult FormHandler(string username, int level)
        //{
        //    return RedirectToAction("Admin");
        //}
        /// <summary>
        /// Read information on a single user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        // GET: Avatar/Details/5
        public ActionResult Read(string username = null)
        {
           // var myData = userBackend.Read(username);
            return View(); //mydata
        }

        /// <summary>
        /// running a read to get the access level to redirect
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include=
                                        "Id,"+
                                        "Name,"+
                                        "Description,"+
                                        "Uri,"+
                                        "AvatarId,"+
                                        "Status,"+
                                        "")] StudentModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit, with Error Message
                return View(data);
            }

            if ( data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Username)
            {
                // Sind back for Edit
                return View(data);
            }

            switch (studentBackend.Read(data.Username).AccessLevel)
            {
                case 1:
                    return RedirectToAction("Action", "Student", new { id = "Index" });

                case 2:
                    return RedirectToAction("Action", "Admin", new { id = "Index" });

                case 3:
                    return RedirectToAction("Action", "Kiosk", new { id = "Index" });

                default:
                    break;

            }
            return RedirectToAction("Index");
        }
        public ActionResult CheckAcess()
        {
            return View(new StudentViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckAccess(string UserName,UserModel data)
        {
            switch (userBackend.Read(data.Username).AccessLevel)
            {
                case 1:
                    return RedirectToAction("Action", "Student", new { id = "Index" });

                case 2:
                    return RedirectToAction("Action", "Admin", new { id = "Index" });

                case 3:
                    return RedirectToAction("Action", "Kiosk", new { id = "Index" });

                default:
                    return RedirectToAction("Index");                 

            }
        }
        /// <summary>
        /// This opens up the make a new User screen
        /// </summary>
        /// <returns></returns>
        // GET: Avatar/Create
        public ActionResult Create()
        {
            var myData = new UserModel();
            return View(myData);
        }

        /// <summary>
        /// Make a new user sent in by the modify user screen
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Avatar/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include=
                                        "Username,"+
                                        "Password,"+
                                        "accessLevel,"+
                                        "")] UserModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit, with Error Message
                return View(data);
            }

            if (data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Username))
            {
                // Sind back for Edit
                return View(data);
            }

            userBackend.Create(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// This will show the details of the avatar to update
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        // GET: Avatar/Edit/5
        public ActionResult Update(string username = null)
        {
            var myData = userBackend.Read(username);
            return View(myData);
        }

        /// <summary>
        /// This updates the avatar based on the information posted from the udpate page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Avatar/Update/5
        [HttpPost]
        public ActionResult Update([Bind(Include=
                                        "Username,"+
                                        "Password,"+
                                        "accessLevel,"+
                                        "")] UserModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }

            if (data == null)
            {
                // Send to error page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Username))
            {
                // Send back for Edit
                return View(data);
            }

            userBackend.Update(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// This shows the avatar info to be deleted
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        // GET: Avatar/Delete/5
        public ActionResult Delete(string username = null)
        {
            var myData = userBackend.Read(username);
            return View(myData);
        }

        /// <summary>
        /// This deletes the avatar sent up as a post from the avatar delete page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Avatar/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include=
                                        "Username,"+
                                        "Password,"+
                                        "accessLevel,"+
                                        "")] UserModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }

            if (data == null)
            {
                // Send to Error Page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Username))
            {
                // Send back for Edit
                return View(data);
            }

            userBackend.Delete(data.Username);

            return RedirectToAction("Index");
        }*/
    }
}