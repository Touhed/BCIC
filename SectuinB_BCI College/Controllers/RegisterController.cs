using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class RegisterController : Controller
    {
        private readonly DataContext db;
        public RegisterController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewRegister(Register r)
        {
            if (ModelState.IsValid)
            {
                Register t = new Register();
                t.RegisterId = r.RegisterId;
                t.RegisterName = r.RegisterName;
                t.Email = r.Email;
                t.Contact = r.Contact;
                t.Address = r.Address;
                db.Register.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewRegisterList");
        }
        public IActionResult AddNewRegister()
        {
            return View();
        }

        public IActionResult EditRegister(Int64 Id)
        {
            var l = db.Register.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditRegister(Register r)
        {
            if (ModelState.IsValid)
            {
                Register t = new Register();
                t.RegisterId = r.RegisterId;
                t.RegisterName = r.RegisterName;
                t.Email = r.Email;
                t.Contact = r.Contact;
                t.Address = r.Address;
                db.Register.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewRegisterList");
        }
        
        public IActionResult DeleteRegister(Int64 Id)
        {
            var l = db.Register.Find(Id);
            db.Register.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult RegisterList()
        {
            var reg = db.Register;
            var i = new List<Register>();
            foreach (var t in reg)

            {
                Register r = new Register();
                r.RegisterId = t.RegisterId;
                r.RegisterName = t.RegisterName;
                r.Email = t.Email;
                r.Contact = t.Contact;
                r.Address = t.Address;
                i.Add(r);
            };
            return View(i);
        }

        public IActionResult ViewRegisterList()
        {
            var reg = db.Register;
            var i = new List<Register>();
            foreach (var t in reg)

            {
                Register r = new Register();
                r.RegisterId = t.RegisterId;
                r.RegisterName = t.RegisterName;
                r.Email = t.Email;
                r.Contact = t.Contact;
                r.Address = t.Address;
                i.Add(r);
            };
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Register.Find(Id);
            return View(l);
        }

        public IActionResult RegisterDetails(Int64 Id)
        {
            var r = db.Register.Find(Id);
            return View(r);
        }
    }
}
