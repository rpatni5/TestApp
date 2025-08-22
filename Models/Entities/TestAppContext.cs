using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestApp.Models.Entities;

namespace TestApp.Models
{
    public class TestAppContext : DbContext
    {
        public TestAppContext() : base("DefaultConnection")
        {
        }
        public DbSet<ApplicationUsers> ApplicationUsers { get; set; }
    }
}