using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;
using TestApp.Models.Entities;
using TestApp.Services.Data;

namespace TestApp.Services.Services
{
    public class SecurityService
    {
        SecurityDao securityDao =   new SecurityDao();

        public ApplicationUsers Authenticate(UserModel model)
        {
           var result =  securityDao.FindByUser(model.UserName, model.Password);
            return result;
        }
    }
}   