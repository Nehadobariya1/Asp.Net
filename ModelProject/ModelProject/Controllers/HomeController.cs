using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelProject.Models;

namespace ModelProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {   
            Student s= new Student();
            s.Id = 1;
            s.Name = "Asp.Net";
            s.Description = "Hello i am student at atmiya university";
            return View(s);
        }
    }
}