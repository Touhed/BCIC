using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupB01_BCIC.Models;
using GroupB01_BCIC.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using GroupB01_BCIC.ViewModel;

namespace GroupB01_BCIC.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext db;
        public AccountController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Start Student Account

        public IActionResult StudentAccountList()
        {
            var a = db.StudentAccount.ToList();
            var b = db.Admission.ToList();
            var c = db.StudentPayment.ToList();
            var i = new List<StudentAccountVM>();
            var query = (from sa in a
                         join ad in b on sa.StudentId equals ad.StudentId
                         join sp in c on sa.StudentId equals sp.StudentId                        
                         select new
                         {
                             StudentId = sa.StudentId,
                             StudentName = sa.StudentName,
                             FixedAmount = ad.FixedAmount,
                             PayAmount = ad.PayAmount,
                             TotalAmount = sp.TotalAmount,
                             SPayAmount = sp.SPayAmount,
                             PaymentDate = sp.PaymentDate,
                             PaymentStatus = ((ad.FixedAmount + sp.TotalAmount) - (ad.PayAmount - sp.SPayAmount))
                         });

            foreach(var item in query)
            {
                StudentAccountVM sa = new StudentAccountVM();
                sa.StudentId = item.StudentId;
                sa.StudentName = item.StudentName;
                sa.FixedAmount = item.FixedAmount;
                sa.PayAmount = item.PayAmount;
                sa.TotalAmount = item.TotalAmount;
                sa.SPayAmount = item.SPayAmount;
                sa.PaymentDate = item.PaymentDate;
                sa.PaymentStatus = item.PaymentStatus; 
                i.Add(sa);
            }
        return View(i);
    }

    public IActionResult ViewStudentAccountList()
    {
	    var a = db.StudentAccount.ToList();
        var b = db.Admission.ToList();
        var c = db.StudentPayment.ToList();
        var i = new List<StudentAccountVM>();
        var query = (from sa in a
                        join ad in b on sa.StudentId equals ad.StudentId
                        join sp in c on sa.StudentId equals sp.StudentId
                        select new
                        {
                            StudentId = sa.StudentId,
                            StudentName = sa.StudentName,
                            FixedAmount = ad.FixedAmount,
                            PayAmount = ad.PayAmount,
                            TotalAmount = sp.TotalAmount,
                            SPayAmount = sp.SPayAmount,
                            PaymentDate = sp.PaymentDate,
                            PaymentStatus = ((ad.FixedAmount + sp.TotalAmount) - (ad.PayAmount + sp.SPayAmount))
                        });
        foreach (var item in query)
        {
            StudentAccountVM sa = new StudentAccountVM();
            sa.StudentId = item.StudentId;
            sa.StudentName = item.StudentName;
            sa.FixedAmount = item.FixedAmount;
            sa.PayAmount = item.PayAmount;
            sa.TotalAmount = item.TotalAmount;
            sa.SPayAmount = item.SPayAmount;
            sa.PaymentDate = item.PaymentDate;
            sa.PaymentStatus = item.PaymentStatus;
            i.Add(sa);
        }
        return View(i);
    }

        public IActionResult StudentAccountSearch(Int64 Id)
        {
            var k = db.StudentAccount.Find(Id);
            return View(k);
        }

        public IActionResult StudentAccountDetails(Int64 Id)
        {
            var m = db.StudentAccount.Find(Id);
            return View(m);
        }

        [HttpPost]
        public IActionResult CreateStudentAccount(StudentAccount sa)
        {
            if (ModelState.IsValid)
            {
                StudentAccount t = new StudentAccount();
                t.StudentId = sa.StudentId;
                t.StudentName = sa.StudentName;
                db.StudentAccount.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewStudentAccountList");
        }
        public IActionResult CreateStudentAccount()
        {
            return View();
        }

        public IActionResult EditStudentAccount(Int64 Id)
        {
            var l = db.StudentAccount.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditStudentAccount(StudentAccount sa)
        {
            if (ModelState.IsValid)
            {
                StudentAccount t = new StudentAccount();
                t.StudentId = sa.StudentId;
                t.StudentName = sa.StudentName;
                t.PaymentStatus = sa.PaymentStatus;
                db.StudentAccount.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewStudentAccountList");
        }
        
        public IActionResult DeleteStudentAccount(Int64 Id)
        {
            var l = db.StudentAccount.Find(Id);
            db.StudentAccount.Remove(l);
            db.SaveChanges();
            return View();
        }

        // Start Student Admission

        public IActionResult AdmissionList()
        {
            var acc = db.Admission;
            var i = new List<AdmissionVM>();
            foreach (var s in acc)
            {
                AdmissionVM t = new AdmissionVM();
                t.AdmissionId = s.AdmissionId;
                t.StudentId = s.StudentId;
                t.AdmissionFees = s.AdmissionFees;
                t.LibraryFee = s.LibraryFee;
                t.LaboratoryFee = s.LaboratoryFee;
                t.FixedAmount = s.FixedAmount;
                t.PayAmount = t.AdmissionFees + t.LibraryFee + t.LaboratoryFee;
                t.PaymentStatus = t.FixedAmount - t.PayAmount;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewAdmissionList()
        {
            var acc = db.Admission;
            var i = new List<AdmissionVM>();
            foreach (var s in acc)
            {
                AdmissionVM t = new AdmissionVM();
                t.AdmissionId = s.AdmissionId;
                t.StudentId = s.StudentId;
                t.AdmissionFees = s.AdmissionFees;
                t.LibraryFee = s.LibraryFee;
                t.LaboratoryFee = s.LaboratoryFee;
                t.FixedAmount = s.FixedAmount;
                t.PayAmount = t.AdmissionFees + t.LibraryFee + t.LaboratoryFee;
                t.PaymentStatus = t.FixedAmount - t.PayAmount;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult AdmissionSearch(Int64 Id)
        {
            var m = db.Admission.Find(Id);
            return View(m);
        }

        public IActionResult AdmissionDetails(Int64 Id)
        {
            var m = db.Admission.Find(Id);
            return View(m);
        }

        [HttpPost]
        public IActionResult AdmissionFee(Admission sa)
        {
            if (ModelState.IsValid)
            {
                Admission t = new Admission();
                t.AdmissionId = sa.AdmissionId;
                t.StudentId = sa.StudentId;
                t.AdmissionFees = sa.AdmissionFees;
                t.LibraryFee = sa.LibraryFee;
                t.LaboratoryFee = sa.LaboratoryFee;
                t.FixedAmount = sa.FixedAmount;
                t.PayAmount = t.AdmissionFees + t.LibraryFee + t.LaboratoryFee;
                t.PaymentStatus = t.FixedAmount - t.PayAmount;
                db.Admission.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewAdmissionList");
        }
        public IActionResult AdmissionFee()
        {
            return View();
        }

        public IActionResult EditAdmissionFee(Int64 Id)
        {
            var l = db.Admission.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditAdmissionFee(Admission sa)
        {
            if (ModelState.IsValid)
            {
                Admission t = new Admission();
                t.AdmissionId = sa.AdmissionId;
                t.StudentId = sa.StudentId;
                t.AdmissionFees = sa.AdmissionFees;
                t.LibraryFee = sa.LibraryFee;
                t.LaboratoryFee = sa.LaboratoryFee;
                t.FixedAmount = sa.FixedAmount;
                t.PayAmount = t.AdmissionFees + t.LibraryFee + t.LaboratoryFee;
                t.PaymentStatus = t.FixedAmount - t.PayAmount;
                db.Admission.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewAdmissionList");
        }

        public IActionResult DeleteAdmission(Int64 Id)
        {
            var l = db.Admission.Find(Id);
            db.Admission.Remove(l);
            db.SaveChanges();
            return View();
        }

        // Start Student Payment 

        public IActionResult StudentPaymentList()
        {
            var acc = db.StudentPayment;
            var i = new List<StudentPaymentVM>();
            foreach (var s in acc)
            {
                StudentPaymentVM t = new StudentPaymentVM();
                t.PaymentId = s.PaymentId;
                t.StudentId = s.StudentId;
                t.Month = s.Month;
                t.Year = s.Year;
                t.TuitionFee = s.TuitionFee;
                t.ExtraFeeCategory = s.ExtraFeeCategory;
                t.ExtraFee = s.ExtraFee;
                t.PaymentDate = s.PaymentDate;
                t.TotalAmount = s.TotalAmount;
                t.SPayAmount = t.TuitionFee + t.ExtraFee;
                t.PaymentStatus = t.TotalAmount - t.SPayAmount;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewStudentPaymentList()
        {
            var acc = db.StudentPayment;
            var i = new List<StudentPaymentVM>();
            foreach (var s in acc)
            {
                StudentPaymentVM t = new StudentPaymentVM();
                t.PaymentId = s.PaymentId;
                t.StudentId = s.StudentId;
                t.Month = s.Month;
                t.Year = s.Year;
                t.TuitionFee = s.TuitionFee;
                t.ExtraFeeCategory = s.ExtraFeeCategory;
                t.ExtraFee = s.ExtraFee;
                t.PaymentDate = s.PaymentDate;
                t.TotalAmount = s.TotalAmount;
                t.SPayAmount = t.TuitionFee + t.ExtraFee;
                t.PaymentStatus = t.TotalAmount - t.SPayAmount;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult StudentPaymentSearch(Int64 Id)
        {
            var m = db.StudentPayment.Find(Id);
            return View(m);
        }

        public IActionResult StudentPaymentDetails(Int64 Id)
        {
            var m = db.StudentPayment.Find(Id);
            return View(m);
        }

        [HttpPost]
        public IActionResult StudentPayment(StudentPayment sp)
        {
            if (ModelState.IsValid)
            {
                StudentPayment t = new StudentPayment();
                t.PaymentId = sp.PaymentId;
                t.StudentId = sp.StudentId;
                t.Month = sp.Month;
                t.Year = sp.Year;
                t.TuitionFee = sp.TuitionFee;
                t.ExtraFeeCategory = sp.ExtraFeeCategory;
                t.ExtraFee = sp.ExtraFee;
                t.PaymentDate = sp.PaymentDate;
                t.TotalAmount = sp.TotalAmount;
                t.SPayAmount = t.TuitionFee + t.ExtraFee;
                t.PaymentStatus = t.TotalAmount - t.SPayAmount;
                db.StudentPayment.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewStudentPaymentList");
        }
        public IActionResult StudentPayment()
        {
            return View();
        }

        public IActionResult EditStudentPayment(Int64 Id)
        {
            var l = db.StudentPayment.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditStudentPayment(StudentPayment sp)
        {
            if (ModelState.IsValid)
            {
                StudentPayment t = new StudentPayment();
                t.PaymentId = sp.PaymentId;
                t.StudentId = sp.StudentId;
                t.Month = sp.Month;
                t.Year = sp.Year;
                t.TuitionFee = sp.TuitionFee;
                t.ExtraFeeCategory = sp.ExtraFeeCategory;
                t.ExtraFee = sp.ExtraFee;
                t.PaymentDate = sp.PaymentDate;
                t.TotalAmount = sp.TotalAmount;
                t.SPayAmount = t.TuitionFee + t.ExtraFee;
                t.PaymentStatus = t.TotalAmount - t.SPayAmount;
                db.StudentPayment.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewStudentPaymentList");
        }

        public IActionResult DeleteStudentPayment(Int64 Id)
        {
            var l = db.StudentPayment.Find(Id);
            db.StudentPayment.Remove(l);
            db.SaveChanges();
            return View();
        }

        // Start Faculty Account

        public IActionResult TeacherAccountList()
        {
            var acc = db.TeacherAccount;
            var i = new List<TeacherAccount>();
            foreach (var f in acc)
            {
                TeacherAccount t = new TeacherAccount();
                t.AccNo = f.AccNo;
                t.TeacherName = f.TeacherName;
                t.TeacherType = f.TeacherType;
                t.TeacherGread = f.TeacherGread;
                t.BasicSalary = f.BasicSalary;
                t.Month = f.Month;
                t.Year = f.Year;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewTeacherAccountList()
        {
            var acc = db.TeacherAccount;
            var i = new List<TeacherAccount>();
            foreach (var f in acc)
            {
                TeacherAccount t = new TeacherAccount();
                t.AccNo = f.AccNo;
                t.TeacherName = f.TeacherName;
                t.TeacherType = f.TeacherType;
                t.TeacherGread = f.TeacherGread;
                t.BasicSalary = f.BasicSalary;
                t.Month = f.Month;
                t.Year = f.Year;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult TeacherAccountSearch(Int64 Id)
        {
            var n = db.TeacherAccount.Find(Id);
            return View(n);
        }

        public IActionResult TeacherAccountDetails(Int64 Id)
        {
            var n = db.TeacherAccount.Find(Id);
            return View(n);
        }

        [HttpPost]
        public IActionResult CreateTeacherAccount(TeacherAccount fa)
        {
            if (ModelState.IsValid)
            {
                TeacherAccount t = new TeacherAccount();
                t.AccNo = fa.AccNo;
                t.TeacherName = fa.TeacherName;
                t.TeacherType = fa.TeacherType;
                t.TeacherGread = fa.TeacherGread;
                t.BasicSalary = fa.BasicSalary;
                t.Month = fa.Month;
                t.Year = fa.Year;
                db.TeacherAccount.Add(t);
                db.SaveChanges();
            }
            return Redirect("ViewTeacherAccountList");
        }

        public IActionResult CreateTeacherAccount()
        {
            return View();
        }

        public IActionResult EditTeacherAccount(Int64 Id)
        {
            var l = db.TeacherAccount.Find(Id);
            return View(l);
        }
        [HttpPost]
        public IActionResult EditTeacherAccount(TeacherAccount fa)
        {
            if (ModelState.IsValid)
            {
                TeacherAccount t = new TeacherAccount();
                t.AccNo = fa.AccNo;
                t.TeacherName = fa.TeacherName;
                t.TeacherType = fa.TeacherType;
                t.TeacherGread = fa.TeacherGread;
                t.BasicSalary = fa.BasicSalary;
                t.Month = fa.Month;
                t.Year = fa.Year;
                db.TeacherAccount.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewTeacherAccountList");
        }
        
        public IActionResult DeleteTeacherAccount(Int64 Id)
        {
            var l = db.TeacherAccount.Find(Id);
            db.TeacherAccount.Remove(l);
            db.SaveChanges();
            return View();
        }
    }
}
