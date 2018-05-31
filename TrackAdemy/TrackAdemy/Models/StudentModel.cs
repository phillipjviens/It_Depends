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


    }
}

