
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TrackAdemy.Models;

namespace TrackAdemy.Backend
{
    /// <summary>
    /// User Backend handles the business logic and data for Users
    /// </summary>
    public class UserBackend
    {
        /// <summary>
        /// Make into a Singleton
        /// </summary>
        private static volatile UserBackend instance;
        private static object syncRoot = new Object();

        private UserBackend() { }

        public static UserBackend Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new UserBackend();
                            SetDataSource();
                            //SetDataSource(SystemGlobals.Instance.DataSourceValue);
                        }
                    }
                }

                return instance;
            }
        }

        // Get the Datasource to use
        private static IUserInterface DataSource;

        /// <summary>
        /// Sets the Datasource to be Mock or SQL
        /// </summary>
        /// /*<param name="dataSourceEnum"></param>*/
        public static void SetDataSource(/*DataSourceEnum dataSourceEnum*/)
        {
            //if (dataSourceEnum == DataSourceEnum.SQL)
            //{
            //    // SQL not hooked up yet...
            //    throw new NotImplementedException();
            //}

            // Default is to use the Mock
            DataSource = UserDataSourceMock.Instance;
        }

        /// <summary>
        /// Makes a new Avatar
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Avatar Passed In</returns>
        public UserModel Create(UserModel data)
        {
            DataSource.Create(data);
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

            var myReturn = DataSource.Read(username);
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

            var myReturn = DataSource.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }

            var myReturn = DataSource.Delete(username);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of Users</returns>
        public List<UserModel> Index()
        {
            var myData = DataSource.Index();
            return myData;
        }

        ///// <summary>
        ///// Helper that returns the First username in the list, this will be used for creating new users if no avatarID is specified
        ///// </summary>
        ///// <returns>Null, or username of the first user in the list.</returns>
        //public string GetFirstUsername()
        //{
        //    string myReturn = null;

        //    var myData = DataSource.Index().ToList().FirstOrDefault();
        //    if (myData != null)
        //    {
        //        myReturn = myData.Username;
        //    }

        //    return myReturn;
        //}

        /// <summary>
        /// Helper function that returns the user's password
        /// </summary>
        /// <param name="data">The user to look up</param>
        /// <returns>null, or the user's password</returns>
        public string GetPassword(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            string myReturn = null;

            var myData = DataSource.Read(data);
            if (myData != null)
            {
                myReturn = myData.Password;
            }

            return myReturn;
        }
       

        /// <summary>
        /// Helper that gets the list of Items, and converst them to a SelectList, so they can show in a Drop Down List box
        /// </summary>
        /// <param name="id">optional paramater, of the Item that is currently selected</param>
        /// <returns>List of SelectListItems as a SelectList</returns>
        //public List<SelectListItem> GetAvatarListItem(string id = null)
        //{
        //    var myDataList = DataSource.Index();

        //    //var myReturn = new SelectList(myDataList);

        //    var myReturn = myDataList.Select(a => new SelectListItem
        //    {
        //        Text = a.Name,
        //        Value = a.Id,
        //        Selected = (a.Id == id),
        //    }).ToList();

        //    return myReturn;
        //}

        /// <summary>
        /// Helper function that resets the DataSource, and rereads it.
        /// </summary>
        public void Reset()
        {
            DataSource.Reset();
        }
    }
}