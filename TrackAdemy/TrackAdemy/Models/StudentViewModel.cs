using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackAdemy.Models
{
    /// <summary>
    /// View Model for the Student Index, this will have the list of the students in it convered to a StudentDisplayViewModel
    /// </summary>
    public class StudentViewModel
    {
        /// <summary>
        /// The student List to return to the View
        /// </summary>
        public List<StudentModel> StudentList = new List<StudentModel>();

   
    }
}