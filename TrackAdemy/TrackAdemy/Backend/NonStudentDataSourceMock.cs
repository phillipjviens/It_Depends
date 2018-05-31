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

        public void Initialize()
        {
            Create(new AdminKioskModel("stevesteve", "stevesteve", 2));
            Create(new AdminKioskModel("kioskkiosk", "kioskkiosk", 3));
        }
}