using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupB01_BCIC.Controllers
{
    public class ManagementController : Controller
    {
        private readonly DataContext db;
        public ManagementController(DataContext x)
        {
            db = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddIncome()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddIncome(IncomeSource i)
        {
            db.IncomeSource.Add(i);
            db.SaveChanges();
            return Redirect("ViewIncomeList");
        }
        public IActionResult EditIncome(Int64 Id)
        {
            var l = db.IncomeSource.Find(Id);
            return View();
        }
        [HttpPost]
        public IActionResult EditActor(IncomeSource a)
        {
            if (ModelState.IsValid)
            {
                IncomeSource t = new IncomeSource();
                t.IncomeId = a.IncomeId;
                t.StudentAdmissionFee = a.StudentAdmissionFee;
                t.StudentSessionFee = a.StudentSessionFee;
                t.StudentTuitionFee = a.StudentTuitionFee;
                t.ExaminationFee = a.ExaminationFee;
                t.FormFillUp = a.FormFillUp;
                t.StationarySell = a.StationarySell;
                t.Donation = a.Donation;
                t.TotalIncome = (t.StudentAdmissionFee+t.StudentSessionFee+t.StudentTuitionFee+t.ExaminationFee+t.FormFillUp+t.StationarySell+t.Donation);
                db.IncomeSource.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewActorList");
        }
        public IActionResult DeleteIncome(Int64 Id)
        {
            var l = db.IncomeSource.Find(Id);
            db.IncomeSource.Remove(l);
            db.SaveChanges();
            return View();
        }
        public IActionResult SearchIncome(Int64 Id)
        {
            var l = db.IncomeSource.Find(Id);
            return View(l);
        }
        public IActionResult IncomeList()
        {
            return View();
        }
    }
}
