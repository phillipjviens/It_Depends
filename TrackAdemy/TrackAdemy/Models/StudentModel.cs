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
        [Display(Name = "CurrentMonth", Description = "Current Month's Hours")]
        [Required(ErrorMessage = "Current month's hours are required.")]
        public string CurrentMonth { get; set; }

        [Display(Name = "ThreeMonths", Description = "Community Hours of the Past 3 Months")]
        [Required(ErrorMessage = "Community hours of the past 3 months is required.")]
        public string ThreeMonths { get; set; }

        /// <summary>
        /// A student's total community hours in the current academic year.
        /// </summary>
        [Display(Name = "Year2Date", Description = "Community Hours this Academic Year")]
        [Required(ErrorMessage = "Community hours of this academic year is required.")]
         public string Year2Date { get; set; }
       
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
        public string DaysAttended { get; set; }

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
            Tokens = 0;
            AvatarLevel = 1;
            Status = StudentStatusEnum.Out;
            ExperiencePoints = 0;
            Password = string.Empty;
        }

        /// <summary>
        /// Constructor for a student
        /// </summary>
        public StudentModel()
        {
            Initialize();
        }

        /// <summary>
        /// Constructor for Student.  Call this when making a new student
        /// </summary>
        /// <param name="name">The Name to call the student</param>
        /// <param name="avatarId">The avatar to use, if not specified, will call the backend to get an ID</param>
        public StudentModel(string name, string avatarId)
        {
            Initialize();

            Name = name;

            // If no avatar ID is sent in, then go and get the first avatar ID from the backend data as the default to use.
            if (string.IsNullOrEmpty(avatarId))
            {
                //avatarId = AvatarBackend.Instance.GetFirstAvatarId();
            }
            AvatarId = avatarId;
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

            Name = data.Name;
            AvatarId = data.AvatarId;
            AvatarLevel = data.AvatarLevel;
            Tokens = data.Tokens;
            Status = data.Status;
            ExperiencePoints = data.ExperiencePoints;
            Password = data.Password;

            return true;
        }
    }
}