using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Services.Data
{
    public class SecurityDao
    {
        public bool FindByUser(string userName, string password)
        {
            if (userName == "admin" && password == "password")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}