using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TrackAdemy.Models
{
    public class UserViewModel
    {
        /// <summary>
        /// creates a collection of all users include admin/student/kiosk
        /// </summary>
        public List<UserModel> UserList = new List<UserModel>();
    }
}