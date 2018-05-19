using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackAdemy.Backend
{
    public class Authenticated
    {
        private string userName;
        private string userPass;
        private int accessLevel;
        private Authenticated(string name, string pass)
        {
            userName = name; userPass = pass; accessLevel = 0;
        }
        private class Admin : Authenticated
        {
            public Admin(string name, string pass) : base(name, pass)
            {
                 accessLevel = 1;
            }
        }
        private class Student : Authenticated
        {
            public Student(string name, string pass) : base(name, pass)
            {               
               accessLevel = 2;
            }
        }
        private class Kiosk : Authenticated
        {
            public Kiosk(string name, string pass) : base(name, pass)
            {
                accessLevel = 3;
            }
        }
        public int GetAccessLevel()
        {
            return accessLevel;
        }
        public string chooseURL()
        {
            if (GetAccessLevel() == 1)
            {
                return ("~/Admin/Index");
            }
            else if (GetAccessLevel() == 2)
            {
                return ("~/Student/Index");
            }
            else if (GetAccessLevel() == 3)
            {
                return ("~/Kiosk/Index");
            }
            else
            {
               throw new Exception( "no access level set");
            }
        }
    }
}