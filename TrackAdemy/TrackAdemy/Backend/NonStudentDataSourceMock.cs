using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TrackAdemy.Models;
namespace TrackAdemy.Backend
{
    /// <summary>
    /// Backend Mock DataSource for NonStudent users, to manage them
    /// </summary>
    public class NonStudentDataSourceMock : IUserInterface
    {
        /// <summary>
        /// Make into a Singleton
        /// </summary>
        private static volatile NonStudentDataSourceMock instance;
        private static object syncRoot = new Object();

        private NonStudentDataSourceMock() { }

        public static NonStudentDataSourceMock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new NonStudentDataSourceMock();
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
        private List<AdminKioskModel> nonStudentList = new List<AdminKioskModel>();

        /// <summary>
        /// Makes a non Student
        /// </summary>
        /// <param name="data"></param>
        /// <returns>non student Passed In</returns>
        public AdminKioskModel Create(AdminKioskModel data)
        {
            nonStudentList.Add(data);
            return data;
        }


        /// <summary>
        /// Return the data for the id passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null or valid data</returns>
        public AdminKioskModel Read(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            var myReturn = nonStudentList.Find(n => n.Id == id);
            return myReturn;
        }

        /// <summary>
        /// Update all attributes to be what is passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Null or updated data</returns>
        public AdminKioskModel Update(AdminKioskModel data)
        {
            if (data == null)
            {
                return null;
            }
            var myReturn = nonStudentList.Find(n => n.Id == data.Id);

            myReturn.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }

            var myData = nonStudentList.Find(n => n.Id == id);
            var myReturn = nonStudentList.Remove(myData);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of nonstudentusers</returns>
        public List<AdminKioskModel> Index()
        {
            return nonStudentList;
        }

        /// <summary>
        /// Reset the Data, and reload it
        /// </summary>
        public void Reset()
        {
            nonStudentList.Clear();
            Initialize();
        }

        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            Create(new AdminKioskModel("stevesteve", "stevesteve", 2));
            Create(new AdminKioskModel("kioskkiosk", "kioskkiosk", 3));
        }
    }
}