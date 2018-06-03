using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackAdemy.Models;
using TrackAdemy.Backend;

namespace TrackAdemy.Controllers
{
    public class StudentController : Controller
    {
        // A ViewModel used for the Student that contains the StudentList
        private StudentViewModel StudentViewModel = new StudentViewModel();

        // The Backend Data source
        private StudentBackend StudentBackend = StudentBackend.Instance;

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

        /// <summary>
        /// This opens up the make a new Student screen
        /// </summary>
        /// <returns></returns>
        // GET: Student/Create
        public ActionResult Create()
        {
            var myData = new StudentModel();
            return View(myData);
        }

        /// <summary>
        /// Make a new Student sent in by the create Student screen
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: Student/Create
        [HttpPost]
        public ActionResult Create([Bind(Include=
                                        "Id,"+
                                        "FirstName,"+
                                        "LastName,"+
                                        "Username,"+
                                        "URICurrentWeek"+
                                        "URICurrentMonth"+
                                        "URI3Months"+
                                        "URIYear2Date"+
                                        "TotalHours"+
                                        "AvgIn"+
                                        "AvgOut"+
                                        "")] StudentModel data)
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

            if (string.IsNullOrEmpty(data.Id))
            {
                // Return back for Edit
                return View(data);
            }

            StudentBackend.Create(data);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// Read information on a single Student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Student/Details/5
        public ActionResult Read(string id = null)
        {
            var myDataStudent = StudentBackend.Read(id);
            if (myDataStudent == null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(myDataStudent);
        }

        /// <summary>
        /// This will show the details of the Student to update
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Student/Edit/5
        public ActionResult Update(string id = null)
        {
            var myDataStudent = StudentBackend.Read(id);
            if (myDataStudent == null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(myDataStudent);
        }

        /// <summary>
        /// This updates the Student based on the information posted from the udpate page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Student/Update/5
        [HttpPost]
        public ActionResult Update([Bind(Include=
                                        "Id,"+
                                        "FirstName,"+
                                        "LastName,"+
                                        "URIProfilePicture,"+
                                        "Username,"+
                                        "Password,"+
                                        "URICurrentWeek,"+
                                        "URICurrentMonth,"+
                                        "URI3Months,"+
                                        "URIYear2Date,"+
                                        "TotalHours,"+
                                        "DaysAttended,"+
                                        "AvgIn,"+
                                        "AvgOut,"+
                                        "")] StudentModel data)
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

            if (string.IsNullOrEmpty(data.ToString()))
            {
                // Send back for edit
                return View(data);
            }

            var myDataStudent = new StudentModel(data);
            StudentBackend.Update(myDataStudent);

            return RedirectToAction("Index");
        }

        /// <summary>
        /// This shows the Student info to be deleted
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Student/Delete/5
        public ActionResult Delete(string id = null)
        {
            var myDataStudent = StudentBackend.Read(id);
            if (myDataStudent == null)
            {
                RedirectToAction("Error", "Home");
            }


            return View(myDataStudent);
        }

        /// <summary>
        /// This deletes the Student sent up as a post from the Student delete page
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete([Bind(Include=
                                        "Id,"+
                                        "FirstName,"+
                                        "LastName,"+
                                        "URIProfilePicture,"+
                                        "Username,"+
                                        "Password,"+
                                        "URICurrentWeek,"+
                                        "URICurrentMonth,"+
                                        "URI3Months,"+
                                        "URIYear2Date,"+
                                        "TotalHours,"+
                                        "DaysAttended,"+
                                        "AvgIn,"+
                                        "AvgOut,"+
                                        "")] StudentModel data)
        {
            if (!ModelState.IsValid)
            {
                // Send back for edit
                return View(data);
            }
            if (data == null)
            {
                // Send to Error page
                return RedirectToAction("Error", new { route = "Home", action = "Error" });
            }

            if (string.IsNullOrEmpty(data.Id))
            {
                // Send back for Edit
                return View(data);
            }

            StudentBackend.Delete(data.Id);

            return RedirectToAction("Index");
        }

    }
}