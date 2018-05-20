using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackAdemy.Models
{
    public class UserModel
    {
        [Display(Name = "Username", Description = "Username")]
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Display(Name = "Password", Description = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "accessLevel", Description = "Access Level")]
        [Required(ErrorMessage = "Access is required")]
        public int AccessLevel { get; set; }
        /// <summary>
        /// Create the default values
        /// </summary>
        public void Initialize()
        {
            AccessLevel = 0;
        }

        /// <summary>
        /// New Avatar
        /// </summary>
        public UserModel()
        {
            Initialize();
        }

        /// <summary>
        /// Make an Avatar from values passed in
        /// </summary>
        /// <param name="username">The Picture path</param>
        /// <param name="password">Avatar Name</param>
        public UserModel(string username, string password)
        {
            Initialize();

            Username = username;
            Password = password;
        }
        private class AdminModel : UserModel
        {
            public AdminModel(string name, string pass) : base(name, pass)
            {
                AccessLevel = 1;
            }
        }
        private class StudentModel : UserModel
        {
            public StudentModel(string name, string pass) : base(name, pass)
            {
                AccessLevel = 2;
            }
        }
        private class KioskModel : UserModel
        {
            public KioskModel(string name, string pass) : base(name, pass)
            {
                AccessLevel = 3;
            }
        }
    }
}

