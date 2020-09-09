using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GroupB01_BCIC.Database;
using GroupB01_BCIC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SectuinB_BCI_College.Models;

namespace GroupB01_BCIC.Controllers
{
    public class UsersController : Controller
    {
        private readonly DataContext db;

        public UsersController(DataContext x)
        {
            db = x;
        }
        public IActionResult Index()
        {
            return View();
        }

        // Login Methode Start

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if (HttpContext.Session.Get("userName") != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Login(Users model)
        {
            var user = db.Users.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
            if (!ModelState.IsValid && user != null)
            {
                string username = user.FirstName + user.LastName;

                HttpContext.Session.Get("userName");

                if (user.UserType.Equals("Admin"))
                {
                    return RedirectToAction("AdminLogin", "Users", new { userName = username });
                }
                else if (user.UserType.Equals("Register"))
                {
                    return RedirectToAction("Index", "Register", new { userName = username });
                }
                else if (user.UserType.Equals("PermanentTeacher"))
                {
                    return RedirectToAction("Index", "PermanentTeacher", new { userName = username });
                }
                else if (user.UserType.Equals("PartTimeTeacher"))
                {
                    return RedirectToAction("Index", "PartTimeTeacher", new { userName = username });
                }
                else if (user.UserType.Equals("Account"))
                {
                    return RedirectToAction("Index", "Account", new { userName = username });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        /*
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userName");
            return RedirectToAction("Users", "Login");
        }
        */

        public IActionResult AdminLogin()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CreateUserAccount(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Add(c);
                db.SaveChanges();
                ModelState.Clear();
            }
            return RedirectToAction("ViewUserList");
        }
        public IActionResult CreateUserAccount()
        {
            return View();
        }

        public IActionResult UserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult ViewUserList()
        {
            var test = db.Users;
            var i = new List<Users>();
            foreach (var l in test)
            {
                Users t = new Users();
                t.LoginId = l.LoginId;
                t.UserId = l.UserId;
                t.UserType = l.UserType;
                t.FirstName = l.FirstName;
                t.LastName = l.LastName;
                t.Email = l.Email;
                t.Password = l.Password;
                i.Add(t);
            }
            return View(i);
        }

        public IActionResult UserDetails(Int64 Id)
        {
            var i = db.Users.Find(Id);
            return View(i);
        }

        public IActionResult Search(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        public IActionResult EditUserDetails(Int64 Id)
        {
            var l = db.Users.Find(Id);
            return View(l);
        }

        [HttpPost]
        public IActionResult EditUserDetails(Users c)
        {
            if (ModelState.IsValid)
            {
                Users t = new Users
                {
                    LoginId = c.LoginId,
                    UserId = c.UserId,
                    UserType = c.UserType,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    Password = c.Password,
                };
                db.Users.Update(t);
                db.SaveChanges();
            }
            return RedirectToAction("ViewUserList");
        }

        public IActionResult DeleteUserData(Int64 Id)
        {
            var l = db.Users.Find(Id);
            db.Users.Remove(l);
            db.SaveChanges();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

/*
	       var test = db.Users;
           var model = new List<Users>();
            
           var s = new Login();
                s.UserType = i.UserType;
                s.Password = i.Password;
                model.Add(s);            
            if(s.UserType == "Admin")
            {returnView("AdminList", model);}
            else if (s.UserType == "Register")
            {returnView("RegisterList", model);}
            else if (s.UserType == "Teacher")
            {returnView("TeacherList", model);}
        */
