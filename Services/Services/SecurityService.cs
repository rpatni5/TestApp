using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApp.Models;
using TestApp.Services.Data;

namespace TestApp.Services.Services
{
    public class SecurityService
    {
        SecurityDao securityDao =   new SecurityDao();

        public bool Authenticate(UserModel model)
        {
            return securityDao.FindByUser(model.UserName, model.Password);
        }
    }
}   