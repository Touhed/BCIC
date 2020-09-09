using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GroupB01_BCIC.Models;
using GroupB01_BCIC.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using SectuinB_BCI_College.Models;
using System.Diagnostics;

namespace GroupB01_BCIC.Controllers
{
    
    public class HomeController : Controller
    {
        
        private readonly DataContext db;
        public HomeController(DataContext x)
        {
            db = x;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewIndex()
        {
            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }

        public IActionResult ViewAbout()
        {

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ViewContact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
