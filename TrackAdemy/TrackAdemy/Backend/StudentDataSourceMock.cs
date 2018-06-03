﻿using System;
using System.Collections.Generic;

using TrackAdemy.Models;

namespace TrackAdemy.Backend
{
    /// <summary>
    /// Holds the Student Data as a Mock Data set, used for Unit Testing, System Testing, Offline Development etc.
    /// </summary>
    public class StudentDataSourceMock : IStudentInterface
    {
        /// <summary>
        /// Make into a singleton
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
        /// The Data for the Students
        /// </summary>
        private List<StudentModel> StudentList = new List<StudentModel>();

        /// <summary>
        /// Makes a new Student
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Student Passed In</returns>
        public StudentModel Create(StudentModel data)
        {
            StudentList.Add(data);
            return data;
        }

        /// <summary>
        /// Return the data for the id passed in
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Null or valid data</returns>
        public StudentModel Read(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }

            var myReturn = StudentList.Find(n => n.Id == id);
            return myReturn;
        }

        /// <summary>
        /// Update all attributes to be what is passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Null or updated data</returns>
        public StudentModel Update(StudentModel data)
        {
            if (data == null)
            {
                return null;
            }
            var myReturn = StudentList.Find(n => n.Id == data.Id);

            myReturn.Update(data);

            return myReturn;
        }

        /// <summary>
        /// Remove the Data item if it is in the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns>True for success, else false</returns>
        public bool Delete(string Id)
        {
            if (string.IsNullOrEmpty(Id))
            {
                return false;
            }

            var myData = StudentList.Find(n => n.Id == Id);
            var myReturn = StudentList.Remove(myData);
            return myReturn;
        }

        /// <summary>
        /// Return the full dataset
        /// </summary>
        /// <returns>List of Students</returns>
        public List<StudentModel> Index()
        {
            return StudentList;
        }

        /// <summary>
        /// Reset the Data, and reload it
        /// </summary>
        public void Reset()
        {
            Initialize();
        }

        /// <summary>
        /// Create Placeholder Initial Data
        /// </summary>
        public void Initialize()
        {
            LoadDataSet(DataSourceDataSetEnum.Default);
        }

        /// <summary>
        /// Clears the Data
        /// </summary>
        private void DataSetClear()
        {
            StudentList.Clear();
        }

        /// <summary>
        /// The Defalt Data Set
        /// </summary>
        private void DataSetDefault()
        {
            DataSetClear();
            string graphDirectory = "/Content/images/SVG/Chart SVG/";
            string profileDir = "/Content/images/StudentImages/Student";
            var count = 1;
            Create(new StudentModel("Alex", "Randall", "alex", "alex", profileDir + count++ + ".png", graphDirectory + "Student_Archive_NovemberHours.svg", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Ashley", "Mortimer", "ashley", "ashley", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Ryan", "Barter", "ryan", "ryan", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Kim", "Reynolds", "kim", "kim", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Lesley", "Carring", "lesley", "lesley", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Ramon", "Leviter", "ramon", "ramon", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            //main example student
            Create(new StudentModel("Jamie", "Curtis", "jamie", "jamie", profileDir + count++ + ".png", graphDirectory + "Student_Home_HoursThisWeek.svg",
                graphDirectory + "Student_Manage_MonthHours.svg", 
                graphDirectory + "Student_Manage_3MonthsHours.svg", 
                graphDirectory + "Student_Manage_YearToDateHours.svg",
                20, 10, "5", "3:45"));
            Create(new StudentModel("Seetal", "Guri", "seetal", "seetal", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
            Create(new StudentModel("Zachary", "Monson", "zachary", "zachary", profileDir + count++ + ".png", "", "", "", "", 20, 10, "5", "3:45"));
        }

        /// <summary>
        /// Data set for demo
        /// </summary>
        private void DataSetDemo()
        {
            DataSetDefault();
        }

        /// <summary>
        /// Unit Test data set
        /// </summary>
        private void DataSetUnitTest()
        {
            DataSetDefault();
        }

        /// <summary>
        /// Set which data to load
        /// </summary>
        /// <param name="setEnum"></param>
        public void LoadDataSet(DataSourceDataSetEnum setEnum)
        {
            switch (setEnum)
            {
                case DataSourceDataSetEnum.Demo:
                    DataSetDemo();
                    break;

                case DataSourceDataSetEnum.UnitTest:
                    DataSetUnitTest();
                    break;

                case DataSourceDataSetEnum.Default:
                default:
                    DataSetDefault();
                    break;
            }
        }
    }
}