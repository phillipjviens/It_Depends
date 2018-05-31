using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackAdemy.Models
{
    public class AdminKioskModel
    {
        /// <summary>
        /// Non-student GUID
        /// </summary>
        [Display(Name = "Id", Description = "Non-student Id")]
        [Required(ErrorMessage = "Id is required")]
        public string Id { get; set; }

        /// <summary>
        /// Non-student's username
        /// </summary>
        [Display(Name = "Username", Description = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        /// <summary>
        /// Non-student's password
        /// </summary>
        [Display(Name = "Password", Description = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }


        /// <summary>
        /// Level of Access
        /// Distinguishes between Admin and Kiosk
        /// Admin: 2
        /// Kiosk: 3
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
        }


        public AdminKioskModel(string username, string password, int accessLevel)
        {
            Initialize();

            Username = username;
            Password = password;
            AccessLevel = accessLevel;
        }
    }
}

