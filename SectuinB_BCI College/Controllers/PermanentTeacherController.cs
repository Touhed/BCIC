using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class PermanentTeacherController : Controller
    {
        private readonly DataContext db;
        public PermanentTeacherController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPermanentTeacher(PermanentTeacher r)
        {
            if (ModelState.IsValid)
            {
                PermanentTeacher t = new PermanentTeacher();
                t.Id = r.Id;
                t.Name = r.Name;
                t.Type = r.Type;
                t.Designation = r.Designation;
                t.Contact = r.Contact;
                t.Address = r.Address;
                t.Email = r.Email;
                db.PermanentTeacher.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewPermanentTeacherList");
        }
        public IActionResult AddPermanentTeacher()
        {
            return View();
        }

        public IActionResult PermanentTeacherList()
        {
            var test = db.PermanentTeacher;
            var i = new List<PermanentTeacher>();
            foreach (var f in test)
            {
                PermanentTeacher t = new PermanentTeacher();
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

        public IActionResult ViewPermanentTeacherList()
        {
            var test = db.PermanentTeacher;
            var i = new List<PermanentTeacher>();
            foreach (var f in test)
            {
                PermanentTeacher t = new PermanentTeacher();
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
            var l = db.PermanentTeacher.Find(Id);
            return View(l);
        }

        public IActionResult PermanentTeacherDetails(Int64 Id)
        {
            var l = db.PermanentTeacher.Find(Id);
            return View(l);
        }
        public IActionResult EditPermanentTeacher(Int64 Id)
        {
            var l = db.PermanentTeacher.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditPermanentTeacher(PermanentTeacher f)
        {
            if (ModelState.IsValid)
            {
                PermanentTeacher t = new PermanentTeacher();
                t.Id = f.Id;
                t.Name = f.Name;
                t.Type = f.Type;
                t.Designation = f.Designation;
                t.Contact = f.Contact;
                t.Address = f.Address;
                t.Email = f.Email;
                db.PermanentTeacher.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewPermanentTeacherList");
        }

        public IActionResult DeletePermanentTeacher(Int64 Id)
        {
            var l = db.PermanentTeacher.Find(Id);
            db.PermanentTeacher.Remove(l);
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
