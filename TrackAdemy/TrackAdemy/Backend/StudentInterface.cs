using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackAdemy.Models;

namespace TrackAdemy.Backend
{
    /// <summary>
    /// The interface for the Student DataSource.
    /// </summary>
    public interface IStudentInterface
    {
        StudentModel Create(StudentModel data);
        StudentModel Read(string id);
        StudentModel Update(StudentModel data);
        StudentModel Archive(StudentModel data);
        bool Delete(string id);
        List<StudentModel> Index();
        void Reset();
        void LoadDataSet(DataSourceDataSetEnum setEnum);
    }
}