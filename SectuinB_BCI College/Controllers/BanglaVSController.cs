using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;


namespace GroupB01_BCIC.Controllers
{
    public class BanglaVSController : Controller
    {
        private readonly DataContext db;
        public BanglaVSController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BanglaVS()
        {
            return View();
        }

        // Bangla Arts Start

        [HttpPost]
        public IActionResult AddBanArtStudent(BanArtStudent s)
        {
            if (ModelState.IsValid)
            {
                BanArtStudent t = new BanArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanArtStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewBanArtStudentList");
        }
        public IActionResult AddBanArtStudent()
        {
            return View();
        }

        public IActionResult BanArtStudentList()
        {
            var test = db.BanArtStudent;
            var i = new List<BanArtStudent>();
            foreach (var s in test)
            {
                BanArtStudent t = new BanArtStudent();
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

        public IActionResult ViewBanArtStudentList()
        {
            var test = db.BanArtStudent;
            var i = new List<BanArtStudent>();
            foreach (var s in test)
            {
                BanArtStudent t = new BanArtStudent();
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

        public IActionResult BanArtStudentSearch(Int64 Id)
        {
            var l = db.BanArtStudent.Find(Id);
            return View(l);
        }

        public IActionResult BanArtStudentDetails(Int64 Id)
        {
            var n = db.BanArtStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditBanArtStudent(Int64 Id)
        {
            var l = db.BanArtStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditBanArtStudent(BanArtStudent s)
        {
            if (ModelState.IsValid)
            {
                BanArtStudent t = new BanArtStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanArtStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewBanArtStudentList");
        }

        public IActionResult DeleteBanArtStudent(Int64 Id)
        {
            var l = db.BanArtStudent.Find(Id);
            db.BanArtStudent.Remove(l);
            db.SaveChanges();
            return View();
        }


        // Bangla Commerce Start

        [HttpPost]
        public IActionResult AddBanComStudent(BanComStudent s)
        {
            if (ModelState.IsValid)
            {
                BanComStudent t = new BanComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanComStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewBanComStudentList");
        }
        public IActionResult AddBanComStudent()
        {
            return View();
        }

        public IActionResult BanComStudentList()
        {
            var test = db.BanComStudent;
            var i = new List<BanComStudent>();
            foreach (var s in test)
            {
                BanComStudent t = new BanComStudent();
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

        public IActionResult ViewBanComStudentList()
        {
            var test = db.BanComStudent;
            var i = new List<BanComStudent>();
            foreach (var s in test)
            {
                BanComStudent t = new BanComStudent();
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

        public IActionResult BanComStudentSearch(Int64 Id)
        {
            var l = db.BanComStudent.Find(Id);
            return View(l);
        }

        public IActionResult BanComStudentDetails(Int64 Id)
        {
            var n = db.BanComStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditBanComStudent(Int64 Id)
        {
            var l = db.BanComStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditBanComStudent(BanComStudent s)
        {
            if (ModelState.IsValid)
            {
                BanComStudent t = new BanComStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanComStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewBanComStudentList");
        }

        public IActionResult DeleteBanComStudent(Int64 Id)
        {
            var l = db.BanComStudent.Find(Id);
            db.BanComStudent.Remove(l);
            db.SaveChanges();
            return View();
        }

        // Bangla Science Start 

        [HttpPost]
        public IActionResult AddBanSciStudent(BanSciStudent s)
        {
            if (ModelState.IsValid)
            {
                BanSciStudent t = new BanSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanSciStudent.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewBanSciStudentList");
        }
        public IActionResult AddBanSciStudent()
        {
            return View();
        }

        public IActionResult BanSciStudentList()
        {
            var test = db.BanSciStudent;
            var i = new List<BanSciStudent>();
            foreach (var s in test)
            {
                BanSciStudent t = new BanSciStudent();
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

        public IActionResult ViewBanSciStudentList()
        {
            var test = db.BanSciStudent;
            var i = new List<BanSciStudent>();
            foreach (var s in test)
            {
                BanSciStudent t = new BanSciStudent();
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

        public IActionResult BanSciStudentSearch(Int64 Id)
        {
            var l = db.BanSciStudent.Find(Id);
            return View(l);
        }

        public IActionResult BanSciStudentDetails(Int64 Id)
        {
            var n = db.BanSciStudent.Find(Id);
            return View(n);
        }

        public IActionResult EditBanSciStudent(Int64 Id)
        {
            var l = db.BanSciStudent.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditBanSciStudent(BanSciStudent s)
        {
            if (ModelState.IsValid)
            {
                BanSciStudent t = new BanSciStudent();
                t.StudentId = s.StudentId;
                t.StudentName = s.StudentName;
                t.Department = s.Department;
                t.PresentAddress = s.PresentAddress;
                t.PermanentAddress = s.PermanentAddress;
                t.Contact = s.Contact;
                t.Email = s.Email;
                db.BanSciStudent.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewBanSciStudentList");
        }

        public IActionResult DeleteBanSciStudent(Int64 Id)
        {
            var l = db.BanSciStudent.Find(Id);
            db.BanSciStudent.Remove(l);
            db.SaveChanges();
            return View();
        }

    }
}


/*
      public IActionResult StudentOne()
       {
           var test = db.BanArtStudent.FirstOrDefault();

           BanArtStudent Sent = new BanArtStudent()
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
