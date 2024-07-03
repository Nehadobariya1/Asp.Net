using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentProject.Models;

namespace StudentProject.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {   
            student s = new student();
            s.Id = 1;
            s.Name = "Prins";
            s.Description = "i am student of Master Of Computer Application";
            s.city = "Rajkot";

            return View(s);
        }
        public ActionResult About()
        {
            ViewBag.Id = new List<int>()
            { 1, 2 ,3};
            ViewBag.Name = new List<string>()
            {
                "krish","Meet","Karm"
            };
            ViewBag.Discription = new List<string>()
            {
                "Student","Student","Employee"
            };
            ViewBag.City = new List<string>()
            {
                "Rajkot","Jungadh","Mahesana"
            };

            return View();

        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}