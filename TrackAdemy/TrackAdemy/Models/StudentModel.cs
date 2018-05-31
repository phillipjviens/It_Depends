﻿using System;
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
        /// Student's current week graph
        /// </summary>
        [Display(Name = "URICurrentWeek", Description = "Current Week")]
        [Required(ErrorMessage = "A graph for the current week is required")]
        public string URICurrentWeek { get; set; }
    }
}

