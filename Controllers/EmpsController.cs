using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LogginPage.EF;
using LogginPage.Models;
using log4net.Config;
using System.Threading.Tasks;

namespace LogginPage.Controllers
{
    [Authorize]
    public class EmpsController : Controller
    {

        log4net.ILog log = log4net.LogManager.GetLogger(typeof(EmpsController)); 
        
        private LogContext db;
        public EmpsController()
        {
            log.Info("Info Log");
            log.Warn("Warning Log");
            db = new LogContext();
        }

        // GET: Emps
        public ActionResult Index()
        {
            var a = db.Emp.ToList();
            return View(a);
        }


      
        public ActionResult Details(int? id)
        {
            
           var a=db.Emp.Find(id);
            if (a == null)
            {
                return HttpNotFound();
            }
            return View(a);
        }

        // GET: Emps/Create
        public ActionResult Create()

        {
            var list = new List<string>();

            list.Add("IT");
            list.Add("SALES");
            list.Add("HR");
          
           
            ViewBag.list=list;

           


            return View();
        }

       [HttpPost]
       
        public ActionResult Create( Employee emps)
        {
            if (ModelState.IsValid)
            {
                db.Emp.Add(emps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           

            return View(emps);
        }

        public ActionResult Edit(int id)
        {
           var v= db.Emp.Find(id);
            if (v == null)
            {
                return HttpNotFound();
            }
            return View(v);
        }

        [HttpPost]
        
        public ActionResult Edit( Employee emps)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emps).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emps);
        }

        // GET: Emps/Delete/5
        public ActionResult Delete(Employee emps)
        {
            return View(emps);
        }

        // POST: Emps/Delete/5
               
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var p=db.Emp.Find(id);
            db.Emp.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

   
        }




    }

