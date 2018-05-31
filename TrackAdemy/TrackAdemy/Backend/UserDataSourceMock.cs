using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TrackAdemy.Models;
namespace TrackAdemy.Backend
{
    /// <summary>
    /// Backend Mock DataSource for User, to manage them
    /// </summary>
    public class UserDataSourceMock : IUserInterface
    {
        /// <summary>
        /// Make into a Singleton
        /// </summary>
        private static volatile UserDataSourceMock instance;
        private static object syncRoot = new Object();

        private UserDataSourceMock() { }

        public static UserDataSourceMock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new UserDataSourceMock();
                            instance.Initialize();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// The User List
        /// </summary>
        private List<UserModel> userList = new List<UserModel>();

        /// <summary>
        /// Makes a new User
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Avatar Passed In</returns>
        public UserModel Create(UserModel data)
        {
            userList.Add(data);
            return data;
        }

        /// <summary>
        /// Return the data for the username passed in
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Null or valid data</returns>
        public UserModel Read(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }

            var myReturn = userList.Find(n => n.Username == username);
            return myReturn;
        }

        /// <summary>
        /// Update all attributes to be what is passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Null or updated data</returns>
        public UserModel Update(UserModel data)
        {
            if (data == null)
            {
                return null;
            }
            var myReturn = userList.Find(n => n.Username == data.Username);

            myReturn.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            var myData = userList.Find(n => n.Username == username);
            var myReturn = userList.Remove(myData);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of users</returns>
        public List<UserModel> Index()
        {
            return userList;
        }

        /// <summary>
        /// Reset the Data, and reload it
        /// </summary>
        public void Reset()
        {
            userList.Clear();
            Initialize();
        }

        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            Create(new UserModel.StudentModel("alexalex","alexalex","Alex", "Randall", ""));
            Create(new UserModel.StudentModel("ashleyashley", "ashleyashley", "Ashley", "Mortimer", ""));
            Create(new UserModel.StudentModel("jamiejamie", "jamiejamie", "Jamie", "Curtis", ""));
            Create(new UserModel.StudentModel("kimkim", "kimkim", "Kim", "Reynolds", ""));
            Create(new UserModel.StudentModel("lesleylesley", "lesleylesley", "Lesley", "Carring", ""));
            Create(new UserModel.StudentModel("ramonramon", "ramonramon","Ramon", "Leviter", ""));
            Create(new UserModel.StudentModel("ryanryan", "ryanryan", "Ryan", "Barter", ""));
            Create(new UserModel.StudentModel("seetalseetal", "seetalseetal", "Seetal", "Guri", ""));
            Create(new UserModel.StudentModel("zacharyzachary", "zacharyzachary", "Zachary", "Monson", ""));
            Create(new UserModel.AdminModel("stevesteve", "stevesteve"));
            Create(new UserModel.KioskModel("kioskkiosk", "kioskkiosk"));
        }
    }
}