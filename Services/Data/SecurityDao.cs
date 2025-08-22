using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;
using TestApp.Models.Entities;
using TestApp.Models.View_Models;

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

        public ApplicationUsers Register(SignupModel model)
        {
            try
            {
                using (var context = new TestAppContext())
                {
                    var user = new ApplicationUsers
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email,
                        UserName = model.Username,
                        Password = model.Password 
                    };

                    context.ApplicationUsers.Add(user);
                    context.SaveChanges();

                    return user; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error registering user: " + ex.Message);
                return null; 
            }
        }

    }
}