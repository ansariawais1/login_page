using LogginPage.Models;
using System.Data.Entity;

namespace LogginPage.EF
{
    public class LogContext:DbContext
    {
        public LogContext():base("TestDB")
        {

        }
        public DbSet<SignUp> US { get; set; }

        public DbSet<Employee> Emp { get; set; } 
       

        public System.Data.Entity.DbSet<LogginPage.Models.Inside.LogInPage> LogInPages { get; set; }
    }
}