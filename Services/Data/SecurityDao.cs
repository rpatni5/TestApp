using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;
using TestApp.Models.Entities;

namespace TestApp.Services.Data
{
    public class SecurityDao
    {
        public ApplicationUsers FindByUser(string userName, string password)
        {
            using (var context = new TestAppContext())
            {
                return context.ApplicationUsers
                              .FirstOrDefault(u => u.UserName == userName
                                                && u.Password == password
                                                && !u.IsDeleted);
            }
        }
    }
}