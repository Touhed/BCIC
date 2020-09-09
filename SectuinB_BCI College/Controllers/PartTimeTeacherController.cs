using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class PartTimeTeacherController : Controller
    {
        private readonly DataContext db;
        public PartTimeTeacherController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPartTimeTeacher(PartTimeTeacher r)
        {
            if (ModelState.IsValid)
            {
                PartTimeTeacher t = new PartTimeTeacher();
                t.Id = r.Id;
                t.Name = r.Name;
                t.Type = r.Type;
                t.Designation = r.Designation;
                t.Contact = r.Contact;
                t.Address = r.Address;
                t.Email = r.Email;
                db.PartTimeTeacher.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewPartTimeTeacherList");
        }
        public IActionResult AddPartTimeTeacher()
        {
            return View();
        }

        public IActionResult PartTimeTeacherList()
        {
            var test = db.PartTimeTeacher;
            var i = new List<PartTimeTeacher>();
            foreach (var f in test)
            {
                PartTimeTeacher t = new PartTimeTeacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Type = f.Type;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewPartTimeTeacherList()
        {
            var test = db.PartTimeTeacher;
            var i = new List<PartTimeTeacher>();
            foreach (var f in test)
            {
                PartTimeTeacher t = new PartTimeTeacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Type = f.Type;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.PartTimeTeacher.Find(Id);
            return View(l);
        }

        public IActionResult PartTimeTeacherDetails(Int64 Id)
        {
            var l = db.PartTimeTeacher.Find(Id);
            return View(l);
        }
        public IActionResult EditPartTimeTeacher(Int64 Id)
        {
            var l = db.PartTimeTeacher.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditPartTimeTeacher(PartTimeTeacher f)
        {
            if (ModelState.IsValid)
            {
                PartTimeTeacher t = new PartTimeTeacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Type = f.Type;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                db.PartTimeTeacher.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewPartTimeTeacherList");
        }

        public IActionResult DeletePartTimeTeacher(Int64 Id)
        {
            var l = db.PartTimeTeacher.Find(Id);
            db.PartTimeTeacher.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}

/*
public IActionResult FacultyOne()
{
    var test = db.Faculty.FirstOrDefault();

    Faculty Sent = new Faculty()
    {
        Id = test.Id,
        Name = test.Name,
        Type = test.Type,
        Designation = test.Designation,
        Contact = test.Contact,
        Address = test.Address,
        Email = test.Email
    };

    return View(Sent);
}
*/
