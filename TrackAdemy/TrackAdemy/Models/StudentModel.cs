using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

using TrackAdemy.Backend;

namespace TrackAdemy.Models
{
    /// <summary>
    /// The Student, this holds the student id, name, tokens.  Other things about the student such as their attendance is pulled from the attendance data, or the owned items, from the inventory data
    /// </summary>
    public class StudentModel
    {
        /// <summary>
        /// The ID for the Student, this is the key, and a required field
        /// </summary>
        [Key]
        [Display(Name = "Id", Description = "Student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        /// <summary>
        /// The student's first name
        /// </summary>
        [Display(Name = "FirstName", Description = "First Name")]
        [Required(ErrorMessage = "Your first name is required")]
        public string FirstName { get; set; }

        /// <summary>
        /// The student's last name
        /// </summary>
        [Display(Name = "LastName", Description = "Last Name")]
        [Required(ErrorMessage = "Your last name is required")]
        public string LastName { get; set; }

        /// <summary>
        /// The path to the student's photo
        /// </summary>
        [Display(Name = "URIProfilePicture", Description = "Student Photo")]
        [Required(ErrorMessage = "A photo is required")]
        public string URIProfilePicture { get; set; }

        /// <summary>
        /// The student's username
        /// </summary>
        [Display(Name = "Username", Description = "Username")]
        [Required(ErrorMessage = "A username is required")]
        public string Username { get; set; }

        /// <summary>
        /// The student's password
        /// </summary>
        [Display(Name = "Password", Description = "Password")]
        [Required(ErrorMessage = "A password is required")]
        public string Password { get; set; }

        /// <summary>
        /// A student's community hours in the current week. Shows the hours accrued per day in the week.
        /// </summary>
        [Display(Name = "URICurrentWeek", Description = "Current Week's Hours")]
        [Required(ErrorMessage = "A graph of the current week is required.")]
        public string URICurrentWeek { get; set; }

        /// <summary>
        /// A student's total community hours in the current month.
        /// </summary>
        [Display(Name = "URICurrentMonth", Description = "Current Month's Hours")]
        [Required(ErrorMessage = "Current month's hours are required.")]
        public string URICurrentMonth { get; set; }

        [Display(Name = "URI3Months", Description = "Community Hours of the Past 3 Months")]
        [Required(ErrorMessage = "Community hours of the past 3 months is required.")]
        public string URI3Months { get; set; }

        /// <summary>
        /// A student's total community hours in the current academic year.
        /// </summary>
        [Display(Name = "URIYear2Date", Description = "Community Hours this Academic Year")]
        [Required(ErrorMessage = "Community hours of this academic year is required.")]
        public string URIYear2Date { get; set; }

        /// <summary>
        /// A student's total community hours since they enrolled.
        /// </summary>
        [Display(Name = "TotalHours", Description = "All-time community hours")]
        [Required(ErrorMessage = "Total community hours is required.")]
        public double TotalHours { get; set; }

        /// <summary>
        /// A student's total days in class this calendar year.
        /// </summary>
        [Display(Name = "DaysAttended", Description = "Total number of days attended this academic year.")]
        [Required(ErrorMessage = "Total community hours is required.")]
        public int DaysAttended { get; set; }

        /// <summary>
        /// A student's average arrival time that year
        /// </summary>
        [Display(Name = "AvgIn", Description = "Average arrival time")]
        [Required(ErrorMessage = "Average arrival time is requrired.")]
        public string AvgIn { get; set; }

        /// <summary>
        /// A student's average departure time that year        
        /// </summary>
        [Display(Name = "AvgOut", Description = "Average departure time")]
        [Required(ErrorMessage = "Average arrival time is requrired.")]
        public string AvgOut { get; set; }

        /// <summary>
        /// The defaults for a new student
        /// </summary>
        public void Initialize()
        {
            Id = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// Constructor for a student
        /// </summary>
        public StudentModel()
        {
            Initialize();
        }

        /// <summary>
        /// This takes a studentModel data and constructs from it.
        /// </summary>
        /// <param name="data"></param>
        public StudentModel(StudentModel data)
        {
            Initialize();

            Id = data.Id;
            FirstName = data.FirstName;
            LastName = data.LastName;
            Username = data.Username;
            Password = data.Password;
            URIProfilePicture = data.URIProfilePicture;
            URICurrentWeek = data.URICurrentWeek;
            URICurrentMonth = data.URICurrentMonth;
            URI3Months = data.URI3Months;
            URIYear2Date = data.URIYear2Date;
            TotalHours = data.TotalHours;
            DaysAttended = data.DaysAttended;
            AvgIn = data.AvgIn;
            AvgOut = data.AvgOut;
        }

        /// <summary>
        /// Constructor for Student.  Call this when making a new student
        /// 
        /// </summary>
        /// <param name="firstname">The last Name to call the student</param>
        /// <param name="lastname">The last name</param>
        /// <param name="username">the username</param>
        /// <param name="password">the password</param>
        /// <param name="profilePic">The URI of the profile pic</param>
        /// <param name="currentweek">the URI for the current week graph</param>
        /// <param name="thismonth">the URI for the current month graph</param>
        /// <param name="threeMonths">the URI for the 3 months graph</param>
        /// <param name="year">the URI for the year to date graph</param>
        /// <param name="totalHours">the total hours</param>
        /// <param name="daysAttended">days attended by the student</param>
        /// <param name="avgin">The student's average check in time</param>
        /// <param name="avgout">The student's average check out time</param>
        public StudentModel(string firstname, string lastname, string username, string password, string profilePic, string currentweek = "Student_Home_HoursThisWeek.svg",
            string thismonth = "Student_Manage_MonthHours.svg", string threeMonths = "Student_Manage_3MonthsHours.svg", string year = "Student_Manage_YearToDateHours.svg", double totalHours = 10.5, int daysAttended = 4, string avgin = "9:50", string avgout = "2:00")
        {
            Initialize();

            FirstName = firstname;
            LastName = lastname;
            Username = username;
            Password = password;
            URIProfilePicture = profilePic;
            URICurrentWeek = currentweek;
            URICurrentMonth = thismonth;
            URI3Months = threeMonths;
            URIYear2Date = year;
            TotalHours = totalHours;
            DaysAttended = daysAttended;
            AvgIn = avgin;
            AvgOut = avgout;


        }

        /// <summary>
        /// Update the Data Fields with the values passed in, do not update the ID.
        /// </summary>
        /// <param name="data">The values to update</param>
        /// <returns>False if null, else true</returns>
        public bool Update(StudentModel data)
        {
            if (data == null)
            {
                return false;
            }
            FirstName = data.FirstName;
            LastName = data.LastName;
            Username = data.Username;
            Password = data.Password;
            URIProfilePicture = data.URIProfilePicture;
            URICurrentWeek = data.URICurrentWeek;
            URICurrentMonth = data.URICurrentMonth;
            URI3Months = data.URI3Months;
            URIYear2Date = data.URIYear2Date;
            TotalHours = data.TotalHours;
            DaysAttended = data.DaysAttended;
            AvgIn = data.AvgIn;
            AvgOut = data.AvgOut;
            return true;
        }

    }
}