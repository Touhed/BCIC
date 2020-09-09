using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class EnglishVSController : Controller
    {
        private readonly DataContext db;
        public EnglishVSController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnglishVS()
        {
            return View();
        }

        // English Arts Start

        [HttpPost]
        public IActionResult AddEngArtStudent(EngArtStudent s)
        {
            if (ModelState.IsValid)
            {
                EngArtStudent t = new EngArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngArtStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewEngArtStudentList");
        }
        public IActionResult AddEngArtStudent()
        {
            return View();
        }

        public IActionResult EngArtStudentList()
        {
            var test = db.EngArtStudent;
            var i = new List<EngArtStudent>();
            foreach (var s in test)
            {
                EngArtStudent t = new EngArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewEngArtStudentList()
        {
            var test = db.EngArtStudent;
            var i = new List<EngArtStudent>();
            foreach (var s in test)
            {
                EngArtStudent t = new EngArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult EngArtStudentSearch(Int64 Id)
        {
            var l = db.EngArtStudent.Find(Id);
            return View(l);
        }

        public IActionResult EngArtStudentDetails(Int64 Id)
        {
            var n = db.EngArtStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditEngArtStudent(Int64 Id)
        {
            var l = db.EngArtStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditEngArtStudent(EngArtStudent s)
        {
            if (ModelState.IsValid)
            {
                EngArtStudent t = new EngArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngArtStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewEngArtStudentList");
        }

        public IActionResult DeleteEngArtStudent(Int64 Id)
        {
            var l = db.EngArtStudent.Find(Id);
            db.EngArtStudent.Remove(l);
            db.SaveChanges();
            return View();
        }


        // English Commerce Start

        [HttpPost]
        public IActionResult AddEngComStudent(EngComStudent s)
        {
            if (ModelState.IsValid)
            {
                EngComStudent t = new EngComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngComStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewEngComStudentList");
        }
        public IActionResult AddEngComStudent()
        {
            return View();
        }

        public IActionResult EngComStudentList()
        {
            var test = db.EngComStudent;
            var i = new List<EngComStudent>();
            foreach (var s in test)
            {
                EngComStudent t = new EngComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewEngComStudentList()
        {
            var test = db.EngComStudent;
            var i = new List<EngComStudent>();
            foreach (var s in test)
            {
                EngComStudent t = new EngComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult EngComStudentSearch(Int64 Id)
        {
            var l = db.EngComStudent.Find(Id);
            return View(l);
        }

        public IActionResult EngComStudentDetails(Int64 Id)
        {
            var n = db.EngComStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditEngComStudent(Int64 Id)
        {
            var l = db.EngComStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditEngComStudent(EngComStudent s)
        {
            if (ModelState.IsValid)
            {
                EngComStudent t = new EngComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngComStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewEngComStudentList");
        }

        public IActionResult DeleteEngComStudent(Int64 Id)
        {
            var l = db.EngComStudent.Find(Id);
            db.EngComStudent.Remove(l);
            db.SaveChanges();
            return View();
        }

        // English Science Start

        [HttpPost]
        public IActionResult AddEngSciStudent(EngSciStudent s)
        {
            if (ModelState.IsValid)
            {
                EngSciStudent t = new EngSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngSciStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewEngSciStudentList");
        }
        public IActionResult AddEngSciStudent()
        {
            return View();
        }

        public IActionResult EngSciStudentList()
        {
            var test = db.EngSciStudent;
            var i = new List<EngSciStudent>();
            foreach (var s in test)
            {
                EngSciStudent t = new EngSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewEngSciStudentList()
        {
            var test = db.EngSciStudent;
            var i = new List<EngSciStudent>();
            foreach (var s in test)
            {
                EngSciStudent t = new EngSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult EngSciStudentSearch(Int64 Id)
        {
            var l = db.EngSciStudent.Find(Id);
            return View(l);
        }

        public IActionResult EngSciStudentDetails(Int64 Id)
        {
            var n = db.EngSciStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditEngSciStudent(Int64 Id)
        {
            var l = db.EngSciStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditEngSciStudent(EngSciStudent s)
        {
            if (ModelState.IsValid)
            {
                EngSciStudent t = new EngSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.EngSciStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewEngSciStudentList");
        }

        public IActionResult DeleteEngSciStudent(Int64 Id)
        {
            var l = db.EngSciStudent.Find(Id);
            db.EngSciStudent.Remove(l);
            db.SaveChanges();
            return View();
        }

    }
}


/*
      public IActionResult StudentOne()
       {
           var test = db.EngArtStudent.FirstOrDefault();

           EngArtStudent Sent = new EngArtStudent()
           {
               StudentId = test.StudentId,
               StudentName = test.StudentName,
               Department = test.Department,
               PresentAddress = test.PresentAddress,
               PermanentAddress = test.PermanentAddress,
               Contact = test.Contact,
               Email = test.Email
           };
           return View(Sent);
       }
 */
