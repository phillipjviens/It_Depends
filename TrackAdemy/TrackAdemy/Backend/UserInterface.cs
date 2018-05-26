using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackAdemy.Models;

namespace TrackAdemy.Backend
{
    /// <summary>
    /// Datasource Interface for Avatars
    /// </summary>
    public interface IUserInterface
    {
        UserModel Create(UserModel data);
        UserModel Read(string id);
        UserModel Update(UserModel data);
        bool Delete(string id);
        List<UserModel> Index();
        void Reset();
    }
}