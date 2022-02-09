using LogginPage.EF;
using LogginPage.Models;
using LogginPage.Models.Inside;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Windows.Forms;

namespace LogginPage.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        LogContext logo;
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(AccountController));
        public AccountController()
        {
            Exception ex = new Exception();
            log.Error($"Is that Error {ex}");
            //Exception ex =new Exception() ;
            //log.Error($"Error Massage {ex}");
            logo = new LogContext();
        }
        public ActionResult Log()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Log(LogInPage logc, SignUp user_I)
        {
           

                bool c = logo.US.Any(x => x.UserName == logc.UserName && x.Password == logc.Password);
                if (c)
                {
                    FormsAuthentication.SetAuthCookie(logc.UserName, false);
                    return RedirectToAction("Index", "Emps");
                }
            else
            {
                Exception ex = new Exception();
                log.Error($"Is that Error {ex}");
                return View ();
            }
        }
     
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(SignUp _I)
        {
            using(var Check = new LogContext())
            {
                Check.US.Add(_I);
                Check.SaveChanges();
            }
            return RedirectToAction("Log");

        }
    }
}