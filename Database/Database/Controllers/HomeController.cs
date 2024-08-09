using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database.Models;

namespace Database.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MyDBEntities db = new MyDBEntities();
            List<Student> std = db.Students.ToList();
            return View(std);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            

            return View();
        }
        public ActionResult Registration(int? id)
        {
            MyDBEntities db = new MyDBEntities();
            Student s = new Student();

            if (id.HasValue)
            {
                s = db.Students.Find(id);
            }

            return View(s);
        }
        [HttpPost]
        public ActionResult Registration(Student s)
        {
            MyDBEntities db = new MyDBEntities();
            if (s.id == 0)
            {
                db.Students.Add(s);
               
            }
            else
            {
                Student ss = db.Students.Find(s.id);
                ss.name = s.name;
                ss.city = s.city;
              

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        

    }
        public ActionResult Delete(int id)
        {
            MyDBEntities db = new MyDBEntities();
            Student std = db.Students.Find(id);
            db.Students.Remove(std);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}