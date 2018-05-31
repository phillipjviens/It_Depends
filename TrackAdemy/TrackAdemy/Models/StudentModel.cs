using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackAdemy.Models
{
    /// <summary>
    /// Students for the system
    /// </summary>
    public class StudentModel
    {
        /// <summary>
        /// Student GUID
        /// </summary>
        [Display(Name = "Id", Description = "Student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        /// <summary>
        /// Student's first name
        /// </summary>
        [Display(Name = "FirstName", Description = "First Name")]
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }

        /// <summary>
        /// Student's last name
        /// </summary>
        [Display(Name = "LastName", Description = "Last Name")]
        [Required(ErrorMessage = "First name is required")]
        public string LastName { get; set; }

        /// <summary>
        /// Student's username
        /// </summary>
        [Display(Name = "Username", Description = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        /// <summary>
        /// Student's password
        /// </summary>
        [Display(Name = "Password", Description = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        /// <summary>
        /// Student's profile picture
        /// </summary>
        [Display(Name = "URIProfilePicture", Description = "ProfilePicture")]
        [Required(ErrorMessage = "A profile picture is required")]
        public string URIProfilePicture { get; set; }

        /// <summary>
        /// Student's community hours graph for the current week
        /// </summary>
        [Display(Name = "URICurrentWeek", Description = "Current Week")]
        [Required(ErrorMessage = "A graph for the current week is required")]
        public string URICurrentWeek { get; set; }

        /// <summary>
        /// Student's community hours graph for the current month
        /// </summary>
        [Display(Name = "URICurrentMonth", Description = "This Month")]
        [Required(ErrorMessage = "A graph for the current month is required")]
        public string URICurrentMonth { get; set; }

        /// <summary>
        /// Student's community hours graph for the past 3 months
        /// </summary>
        [Display(Name = "URIPast3Months", Description = "Past 3 Months")]
        [Required(ErrorMessage = "A graph for the past 3 months is required")]
        public string URIPast3Months { get; set; }

        /// <summary>
        /// Student's year-to-date community hours graph
        /// </summary>
        [Display(Name = "URIYear2Date", Description = "Year to Date")]
        [Required(ErrorMessage = "A year to date graph is required")]
        public string URIYear2Date { get; set; }

        /// <summary>
        /// Student's total community hours
        /// </summary>
        [Display(Name = "TotalHours", Description = "Total Community Hours")]
        [Required(ErrorMessage = "Total community hours is required")]
        public float TotalHours { get; set; }

        /// <summary>
        /// Student's number of days attending class
        /// </summary>
        [Display(Name = "DaysAttended", Description = "Number of Days Attended")]
        [Required(ErrorMessage = "Number of days attending class is required")]
        public int DaysAttended { get; set; }

        /// <summary>
        /// Student's average arrival time
        /// </summary>
        [Display(Name = "AvgIn", Description = "Average arrival time")]
        [Required(ErrorMessage = "Average arrival time is required")]
        public string AvgIn { get; set; }

        /// <summary>
        /// Student's average departure time
        /// </summary>
        [Display(Name = "AvgOut", Description = "Average departure time")]
        [Required(ErrorMessage = "Average departure time is required")]
        public string AvgOut { get; set; }

        /// <summary>
        /// Level of Access
        /// Distinguishes between Student and AdminKiosk
        /// </summary>
        [Display(Name = "AccessLevel", Description = "Access Level")]
        [Required(ErrorMessage = "Access Level is required")]
        public int AccessLevel { get; set; }

        /// <summary>
        /// Create the default values
        /// </summary>
        public void Initialize()
        {
            Id = Guid.NewGuid().ToString();

            // A student's AccessLevel is 1
            AccessLevel = 1;
        }

        public StudentModel(string first, string last, string username, string password, string profilePic, string currentWeek, string currentMonth, string past3Months, string year2Date, float totalHours, int daysAttended, string avgIn, string avgOut)
        {
            Initialize();

            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            URIProfilePicture = profilePic;
            URICurrentWeek = currentWeek;
            URICurrentMonth = currentMonth;
            URIPast3Months = past3Months;
            URIYear2Date = year2Date;
            TotalHours = totalHours;
            DaysAttended = daysAttended;
            AvgIn = avgIn;
            AvgOut = avgOut;
        }

        public void Updatate(StudentModel data)
        {
            if(data == null)
            {
                return;
            }

            FirstName = data.FirstName;
            LastName = data.LastName;
            Username = data.Username;
            Password = data.Password;
            URIProfilePicture = data.URIProfilePicture;
            URICurrentWeek = data.URICurrentWeek;
            URICurrentMonth = data.URICurrentMonth;
            URIPast3Months = data.URIPast3Months;
            URIYear2Date = data.URIYear2Date;
            TotalHours = data.TotalHours;
            DaysAttended = data.DaysAttended;
            AvgIn = data.AvgIn;
            AvgOut = data.AvgOut;
        }
    }
}

