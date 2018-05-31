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
    }
}

