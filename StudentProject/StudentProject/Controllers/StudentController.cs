using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
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
            List<student> std = new List<student>
            {
                new student() { Id = 1,Name = "Krish", Description="I am student os MCA",city="Rajkot"},
                new student() { Id = 2,Name = "prinsh", Description="I am student os MBA",city="jungadh"},
                new student() { Id = 3,Name = "raj", Description="I am student os MA",city="jamnagar"},
                new student() { Id = 4,Name = "ravi", Description="I am student os MSC",city="surat"},
                new student() { Id = 5,Name = "hardik", Description="I am student os M.COM",city="gondal"}
            };
            return View(std);
        }
    }
}