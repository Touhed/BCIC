using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext db;
        public AdminController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAdmin(Admin a)
        {
            if (ModelState.IsValid)
            {
                Admin t = new Admin();
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                db.Admin.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewAdminList");
        }
        public IActionResult AddNewAdmin()
        {
            return View();
        }

        public IActionResult EditAdmin(Int64 Id)
        {
            var l = db.Admin.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditAdmin(Admin a)
        {
            if (ModelState.IsValid)
            {
                Admin t = new Admin();
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                db.Admin.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewAdminList");
        }
        
        public IActionResult DeleteAdmin(Int64 Id)
        {
            var l = db.Admin.Find(Id);
            db.Admin.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult AdminList()
        {
            var bci = db.Admin;
            var i = new List<Admin>();
            foreach (var a in bci)
            {
                Admin t = new Admin();
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewAdminList()
        {
            var bci = db.Admin;
            var i = new List<Admin>();
            foreach (var a in bci)
            {
                Admin t = new Admin();
                t.AdminId = a.AdminId;
                t.Name = a.Name;
                t.Email = a.Email;
                t.Contact = a.Contact;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult AdminDetails(Int64 Id)
        {
            var k = db.Admin.Find(Id);
            return View(k);
        }

        public IActionResult Search(Int64 Id)
        {
            var k = db.Admin.Find(Id);
            return View(k);
        }
    }
}
