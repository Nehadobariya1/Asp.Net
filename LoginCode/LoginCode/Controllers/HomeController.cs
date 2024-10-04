using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginCode.Models;

namespace LoginCode.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(reg r)
        {

            // Check if the passwords match
            if (r.password != r.ConfirmPassword)
            {
                TempData["msg"] = "Passwords do not match.";
                return View(r); 
            }


            reg rr = new reg();

            mydbEntities db = new mydbEntities();
            rr = db.regs.Where(a => a.username == r.username).FirstOrDefault();

            if(rr==null)
            {
                db.regs.Add(r);
                db.SaveChanges();

            }
            else
            {
                TempData["msg"] = "This user is Already exist !!";
            }
            return RedirectToAction("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login()
        {
       

            return View();
        }
        [HttpPost]
        public ActionResult Login(reg r)
        {

            reg rr = new reg();

            mydbEntities db = new mydbEntities();
            rr = db.regs.Where(a => a.username == r.username && a.password == r.password).FirstOrDefault();

            if (rr != null)
            {
                TempData["msg"] = "Successfully logged in!";
                return RedirectToAction("About");

            }
            else
            {
                TempData["msg"] = "Wrong username or password.";
            }
          
            return View();
        }

    }
}