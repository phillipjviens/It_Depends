using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TrackAdemy.Models;
namespace TrackAdemy.Backend
{
    /// <summary>
    /// Backend Mock DataSource for Student Users, to manage them
    /// </summary>
    public class StudentDataSourceMock : IUserInterface
    {
        /// <summary>
        /// Make into a Singleton
        /// </summary>
        private static volatile StudentDataSourceMock instance;
        private static object syncRoot = new Object();

        private StudentDataSourceMock() { }

        public static StudentDataSourceMock Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new StudentDataSourceMock();
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
        private List<StudentModel> studentList = new List<StudentModel>();


        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            Create(new StudentModel("Ryan", "Barter", "ryanryan", "ryanryan", "~/Content/images/NewFolder1/StudentImagesPNG/Student1.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg", 
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Lesley", "Carring", "lesleylesley", "lesleylesley", "~/Content/images/NewFolder1/StudentImagesPNG/Student3.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Jamie", "Curtis", "jamiejamie", "jamiejamie", "~/Content/images/NewFolder1/StudentImagesPNG/Student6.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Seetal", "Guri", "seetalseetal", "seetalseetal", "~/Content/images/NewFolder1/StudentImagesPNG/Student5.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg", 
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Ramon", "Leviter", "ramonramon", "ramonramon", "~/Content/images/NewFolder1/StudentImagesPNG/Student2.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Zachary", "Monson", "zacharyzachary", "zacharyzachary", "~/Content/images/NewFolder1/StudentImagesPNG/Student9.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Ashley", "Mortimer", "ashelyashely", "ashleyashley", "~/Content/images/NewFolder1/StudentImagesPNG/Student7.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Alex", "Randall", "alexalex", "alexalex", "~/Content/images/NewFolder1/StudentImagesPNG/Student4.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
            Create(new StudentModel("Kim", "Reynolds", "kimkim", "kimkim", "~/Content/images/NewFolder1/StudentImagesPNG/Student8.png", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk1.svg",
                "~/Content/images/SVG/Chart SVG/Admin_Manage_Monthhours.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk2.svg", "~/Content/images/SVG/Chart SVG/Student_Archive_NovemberWk3.svg",
                245.7, 34, "8:55", "2:30"));
        }
    }
}